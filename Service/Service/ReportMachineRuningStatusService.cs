using Common;
using Common.ViewModels;
using Service.IService;

namespace Service.Service
{
    public class ReportMachineRuningStatusService : IReportMachineRuningStatusService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="MachineGroupID"></param>
        /// <param name="MachineLocationID"></param>
        /// <param name="MachineID">Tham số này chỉ dùng cho màn hình chi tiết (Xem chi tiết 1 máy)</param>
        /// <returns></returns>
        public List<MachineRuningStatusViewModel> GetReportMachineRuningStatus(DateTime startDate, DateTime endDate, string MachineGroupID, string MachineLocationID, string MachineID = "")
        {
            List<MachineRuningStatusViewModel> reval = new List<MachineRuningStatusViewModel>();
            try
            {
                // Lịch sử trạng thái của tất cả các máy, các vị trí trong khoảng thời gian xác định
                var hisData = (from h in StaticData.Data_MachineStatusHistory
                               where (h.StatusTime >= startDate && h.StatusTime <= endDate)
                               join m in StaticData.Data_Machine on h.MachineID equals m.MachineID
                               //join ls in StaticData.Data_MachineLocationSetup on h.MachineID equals ls.MachineID
                               join l in StaticData.Data_MachineLocation on h.MachineLocationID equals l.LocationID
                               join s in StaticData.Data_MachineStatus on h.StatusID equals s.StatusID
                               orderby h.StatusTime
                               select new
                               {

                                   //h.MachineStatusHistoryID
                                   // ,
                                   h.MachineID
                                    ,
                                   h.StatusID
                                    ,
                                   h.StatusTime
                                    ,
                                   s.StatusName
                                    ,
                                   s.ColorCode
                                    ,
                                   m.MachineGroupID
                                    ,
                                   m.MachineGroupName
                                    ,
                                   m.Model
                                    ,
                                   m.ImageUrl
                                    ,
                                   m.MachineName
                                    ,
                                   h.MachineLocationID
                                    ,
                                   l.LocationName
                               }).Distinct();

                #region Filter
                if (!string.IsNullOrEmpty(MachineID) && MachineID.ToLower() != "all")
                {
                    hisData = from h in hisData
                              where h.MachineID.ToString() == MachineID
                              select h;
                }

                if (!string.IsNullOrEmpty(MachineGroupID) && MachineGroupID.ToLower() != "all")
                {
                    hisData = from h in hisData
                              where h.MachineGroupID.ToString() == MachineGroupID
                              select h;
                }

                if (!string.IsNullOrEmpty(MachineLocationID) && MachineLocationID.ToLower() != "all")
                {
                    hisData = from h in hisData
                              where h.MachineLocationID.ToString() == MachineLocationID
                              select h;
                }

                #endregion

                #region asign data


                var listMachine = hisData
                    .DistinctBy(d => new
                    {
                        d.MachineID
                                   ,
                        d.MachineGroupID
                                   ,
                        d.MachineGroupName
                                   ,
                        d.MachineName
                                   ,
                        d.Model
                                   ,
                        d.ImageUrl
                                    ,
                        d.MachineLocationID
                                   ,
                        d.LocationName

                    }).ToList()
                    .Take(50);// Fake 50 dòng thôi cho nhẹ


                foreach (var item in listMachine)
                {
                    #region Populate timeline by status

                    List<TimelineSeriesData> timeline = new List<TimelineSeriesData>();

                    var tempHisData = hisData?.Where(m => m.MachineID == item.MachineID && m.MachineLocationID == item.MachineLocationID)?.OrderBy(o => o.StatusTime);

                    if (tempHisData != null)
                    {
                        foreach (var h in tempHisData)
                        {
                            var sd = new TimelineSeriesData()
                            {
                                x = h.StatusName,
                                fillColor = h.ColorCode,
                                _StatusID = h.StatusID,
                            };

                            #region Mốc start: Time của bản ghi hiện tại
                            sd.y.Add((long)(h.StatusTime - new DateTime(1970, 1, 1)).TotalMilliseconds);
                            #endregion

                            #region Mốc end: Time của bản ghi kế tiếp để làm mốc kết thúc cho status hiện tại

                            var t2 = (from dt in tempHisData
                                      orderby dt.StatusTime ascending
                                      where dt.StatusTime > h.StatusTime
                                      select new { StatusTime = (DateTime)dt.StatusTime })?.FirstOrDefault()?.StatusTime;

                            // Nếu không tìm thấy mốc thứ 2 hoặc tìm thấy nhưng nằm ngoài khoảng date đã chọn thì set = mốc cuối của date đã chọn
                            if (t2 is null || t2 > endDate)
                                t2 = endDate;
                            sd.y.Add((long)(t2.Value - new DateTime(1970, 1, 1)).TotalMilliseconds);

                            #endregion

                            //var a = (from dt in hisData
                            //         orderby dt.StatusTime ascending
                            //         where dt.StatusTime > h.StatusTime
                            //         select new { StatusTime = (DateTime)dt.StatusTime }).FirstOrDefault().StatusTime
                            //        ;

                            timeline.Add(sd);
                        }
                    }
                    // Nếu trạng thái nào không có dữ liệu history thì tạo 1 bản ghi trùng start và end
                    // lấy bằng giờ nhỏ nhất trong khoảng thời gian search để hiển thị 1 thanh trên biểu đồ

                    foreach (var ists in StaticData.Data_MachineStatus)
                    {
                        var tt1 = timeline.Where(t => t._StatusID == ists.StatusID).FirstOrDefault();
                        if (tt1 == null)
                        {
                            timeline.Add(new TimelineSeriesData()
                            {
                                x = ists.StatusName,
                                fillColor = ists.ColorCode,
                                _StatusID = ists.StatusID,
                                y = new List<long>()
                                {
                                    timeline.FirstOrDefault().y[0] // Start === end
                                    , timeline.FirstOrDefault().y[0] // Start === end
                                }
                            });
                        }
                    }

                    #endregion

                    #region Tính % các trạng thái (đơn vị cơ sở tính = mili giây)
                    double baseTimeRange_milisecond = (endDate - startDate).TotalMilliseconds;
                    long realTotalmiliSeconds = 0;

                    List<Common.Data_MachineStatus> listStatusPercent = new List<Data_MachineStatus>();
                    foreach (var s in StaticData.Data_MachineStatus)
                    {
                        realTotalmiliSeconds = 0;
                        var sPcent = new Data_MachineStatus() { ColorCode = s.ColorCode, StatusID = s.StatusID, StatusName = s.StatusName, StatusDetail = s.StatusDetail };

                        try
                        {
                            var allSt = timeline?.Where(t => t._StatusID == s.StatusID);
                            if (allSt != null && allSt.Any())
                            {
                                foreach (var tempSt in allSt)
                                {
                                    realTotalmiliSeconds += (tempSt.y[1] - tempSt.y[0]);
                                }
                            }

                            sPcent.DataPercent = (long)(realTotalmiliSeconds * 100 / baseTimeRange_milisecond);

                        }
                        catch (Exception)
                        {

                        }

                        listStatusPercent.Add(sPcent);
                    }


                    #endregion

                    // Add machine
                    reval.Add(new MachineRuningStatusViewModel()
                    {
                        MachineID = item.MachineID,
                        MachineName = item.MachineName,
                        Model = item.Model,
                        ImageUrl = (!string.IsNullOrEmpty(item.ImageUrl) ? item.ImageUrl : "NoImage.png"), // OEE\WDI.OEE\wwwroot\images\products\NoImage.png
                        MachineLocationName = item.LocationName,
                        MachineLocationID = item.MachineLocationID,
                        ListStatusPercent = listStatusPercent,
                        StatusHistories = (from h in hisData
                                           where h.MachineID == item.MachineID && h.MachineLocationID == item.MachineLocationID
                                           select new Common.Data_MachineStatusHistory()
                                           {
                                               MachineID = h.MachineID,
                                               StatusID = h.StatusID,
                                               StatusTime = h.StatusTime
                                           }).ToList()
                                           ,
                        SeriesTimeLine = timeline ?? new List<TimelineSeriesData>()
                    });
                }


                #endregion

            }
            catch (Exception)
            {

            }

            // return reval?.Take(50)?.ToList() ?? new List<MachineRuningStatusViewModel>();
            return reval;
        }


        public List<TimelineSeriesData> GetListTimelineByMachineID(int machineID, DateTime startDate, DateTime endDate)
        {
            List<TimelineSeriesData> reval = new List<TimelineSeriesData>();
            try
            {
                // Lịch sử trạng thái của tất cả các máy, các vị trí trong khoảng thời gian xác định
                var hisData = (from h in StaticData.Data_MachineStatusHistory
                               where (h.StatusTime >= startDate && h.StatusTime <= endDate)
                               join m in StaticData.Data_Machine on h.MachineID equals m.MachineID
                               where (m.MachineID == machineID)
                               //join ls in StaticData.Data_MachineLocationSetup on h.MachineID equals ls.MachineID
                               join l in StaticData.Data_MachineLocation on h.MachineLocationID equals l.LocationID
                               join s in StaticData.Data_MachineStatus on h.StatusID equals s.StatusID
                               orderby h.StatusTime
                               select new
                               {

                                   //h.MachineStatusHistoryID
                                   // ,
                                   h.MachineID
                                    ,
                                   h.StatusID
                                    ,
                                   h.StatusTime
                                    ,
                                   s.StatusName
                                    ,
                                   s.ColorCode
                                    ,
                                   m.MachineGroupID
                                    ,
                                   m.MachineGroupName
                                    ,
                                   m.Model
                                    ,
                                   m.ImageUrl
                                    ,
                                   m.MachineName
                                    ,
                                   h.MachineLocationID
                                    ,
                                   l.LocationName
                               }).Distinct();



                #region asign data


                var listMachine = hisData
                    .DistinctBy(d => new
                    {
                        d.MachineID
                                   ,
                        d.MachineGroupID
                                   ,
                        d.MachineGroupName
                                   ,
                        d.MachineName
                                   ,
                        d.Model
                                   ,
                        d.ImageUrl
                                    ,
                        d.MachineLocationID
                                   ,
                        d.LocationName

                    }).FirstOrDefault(t => t.MachineID == machineID);


                var item = listMachine;
                #region Populate timeline by status

                List<TimelineSeriesData> timeline = new List<TimelineSeriesData>();

                var tempHisData = hisData?.Where(m => m.MachineID == item.MachineID && m.MachineLocationID == item.MachineLocationID)?.OrderBy(o => o.StatusTime);

                if (tempHisData != null)
                {
                    foreach (var h in tempHisData)
                    {
                        var sd = new TimelineSeriesData()
                        {
                            x = h.StatusName,
                            fillColor = h.ColorCode,
                            _StatusID = h.StatusID,
                        };

                        #region Mốc start: Time của bản ghi hiện tại
                        sd.y.Add((long)(h.StatusTime - new DateTime(1970, 1, 1)).TotalMilliseconds);
                        #endregion

                        #region Mốc end: Time của bản ghi kế tiếp để làm mốc kết thúc cho status hiện tại

                        var t2 = (from dt in tempHisData
                                  orderby dt.StatusTime ascending
                                  where dt.StatusTime > h.StatusTime
                                  select new { StatusTime = (DateTime)dt.StatusTime })?.FirstOrDefault()?.StatusTime;

                        // Nếu không tìm thấy mốc thứ 2 hoặc tìm thấy nhưng nằm ngoài khoảng date đã chọn thì set = mốc cuối của date đã chọn
                        if (t2 is null || t2 > endDate)
                            t2 = endDate;
                        sd.y.Add((long)(t2.Value - new DateTime(1970, 1, 1)).TotalMilliseconds);

                        #endregion

                        //var a = (from dt in hisData
                        //         orderby dt.StatusTime ascending
                        //         where dt.StatusTime > h.StatusTime
                        //         select new { StatusTime = (DateTime)dt.StatusTime }).FirstOrDefault().StatusTime
                        //        ;

                        timeline.Add(sd);
                    }
                }
                // Nếu trạng thái nào không có dữ liệu history thì tạo 1 bản ghi trùng start và end
                // lấy bằng giờ nhỏ nhất trong khoảng thời gian search để hiển thị 1 thanh trên biểu đồ

                foreach (var ists in StaticData.Data_MachineStatus)
                {
                    var tt1 = timeline.Where(t => t._StatusID == ists.StatusID).FirstOrDefault();
                    if (tt1 == null)
                    {
                        timeline.Add(new TimelineSeriesData()
                        {
                            x = ists.StatusName,
                            fillColor = ists.ColorCode,
                            _StatusID = ists.StatusID,
                            y = new List<long>()
                                {
                                    timeline.FirstOrDefault().y[0] // Start === end
                                    , timeline.FirstOrDefault().y[0] // Start === end
                                }
                        });
                    }
                }

                #endregion

                #region Tính % các trạng thái (đơn vị cơ sở tính = mili giây)
                double baseTimeRange_milisecond = (endDate - startDate).TotalMilliseconds;
                long realTotalmiliSeconds = 0;

                List<Common.Data_MachineStatus> listStatusPercent = new List<Data_MachineStatus>();
                foreach (var s in StaticData.Data_MachineStatus)
                {
                    realTotalmiliSeconds = 0;
                    var sPcent = new Data_MachineStatus() { ColorCode = s.ColorCode, StatusID = s.StatusID, StatusName = s.StatusName, StatusDetail = s.StatusDetail };

                    try
                    {
                        var allSt = timeline?.Where(t => t._StatusID == s.StatusID);
                        if (allSt != null && allSt.Any())
                        {
                            foreach (var tempSt in allSt)
                            {
                                realTotalmiliSeconds += (tempSt.y[1] - tempSt.y[0]);
                            }
                        }

                        sPcent.DataPercent = (long)(realTotalmiliSeconds * 100 / baseTimeRange_milisecond);

                    }
                    catch (Exception)
                    {

                    }

                    listStatusPercent.Add(sPcent);
                }


                #endregion


                #endregion

                reval = timeline ?? new List<TimelineSeriesData>();
            }
            catch (Exception)
            {

            }
            return reval;
        }
        public List<Common.Data_MachineStatus> GetListStatusPercentByMachineID(int machineID, DateTime startDate, DateTime endDate)
        {
            List<Data_MachineStatus> reval = new List<Data_MachineStatus>();
            try
            {
                // Lịch sử trạng thái của tất cả các máy, các vị trí trong khoảng thời gian xác định
                var hisData = (from h in StaticData.Data_MachineStatusHistory
                               where (h.StatusTime >= startDate && h.StatusTime <= endDate)
                               join m in StaticData.Data_Machine on h.MachineID equals m.MachineID
                               where (m.MachineID == machineID)
                               //join ls in StaticData.Data_MachineLocationSetup on h.MachineID equals ls.MachineID
                               join l in StaticData.Data_MachineLocation on h.MachineLocationID equals l.LocationID
                               join s in StaticData.Data_MachineStatus on h.StatusID equals s.StatusID
                               orderby h.StatusTime
                               select new
                               {

                                   //h.MachineStatusHistoryID
                                   // ,
                                   h.MachineID
                                    ,
                                   h.StatusID
                                    ,
                                   h.StatusTime
                                    ,
                                   s.StatusName
                                    ,
                                   s.ColorCode
                                    ,
                                   m.MachineGroupID
                                    ,
                                   m.MachineGroupName
                                    ,
                                   m.Model
                                    ,
                                   m.ImageUrl
                                    ,
                                   m.MachineName
                                    ,
                                   h.MachineLocationID
                                    ,
                                   l.LocationName
                               }).Distinct();



                #region asign data


                var listMachine = hisData
                    .DistinctBy(d => new
                    {
                        d.MachineID
                                   ,
                        d.MachineGroupID
                                   ,
                        d.MachineGroupName
                                   ,
                        d.MachineName
                                   ,
                        d.Model
                                   ,
                        d.ImageUrl
                                    ,
                        d.MachineLocationID
                                   ,
                        d.LocationName

                    }).FirstOrDefault(t => t.MachineID == machineID);


                var item = listMachine;
                #region Populate timeline by status

                List<TimelineSeriesData> timeline = new List<TimelineSeriesData>();

                var tempHisData = hisData?.Where(m => m.MachineID == item.MachineID && m.MachineLocationID == item.MachineLocationID)?.OrderBy(o => o.StatusTime);

                if (tempHisData != null)
                {
                    foreach (var h in tempHisData)
                    {
                        var sd = new TimelineSeriesData()
                        {
                            x = h.StatusName,
                            fillColor = h.ColorCode,
                            _StatusID = h.StatusID,
                        };

                        #region Mốc start: Time của bản ghi hiện tại
                        sd.y.Add((long)(h.StatusTime - new DateTime(1970, 1, 1)).TotalMilliseconds);
                        #endregion

                        #region Mốc end: Time của bản ghi kế tiếp để làm mốc kết thúc cho status hiện tại

                        var t2 = (from dt in tempHisData
                                  orderby dt.StatusTime ascending
                                  where dt.StatusTime > h.StatusTime
                                  select new { StatusTime = (DateTime)dt.StatusTime })?.FirstOrDefault()?.StatusTime;

                        // Nếu không tìm thấy mốc thứ 2 hoặc tìm thấy nhưng nằm ngoài khoảng date đã chọn thì set = mốc cuối của date đã chọn
                        if (t2 is null || t2 > endDate)
                            t2 = endDate;
                        sd.y.Add((long)(t2.Value - new DateTime(1970, 1, 1)).TotalMilliseconds);

                        #endregion

                        //var a = (from dt in hisData
                        //         orderby dt.StatusTime ascending
                        //         where dt.StatusTime > h.StatusTime
                        //         select new { StatusTime = (DateTime)dt.StatusTime }).FirstOrDefault().StatusTime
                        //        ;

                        timeline.Add(sd);
                    }
                }
                // Nếu trạng thái nào không có dữ liệu history thì tạo 1 bản ghi trùng start và end
                // lấy bằng giờ nhỏ nhất trong khoảng thời gian search để hiển thị 1 thanh trên biểu đồ

                foreach (var ists in StaticData.Data_MachineStatus)
                {
                    var tt1 = timeline.Where(t => t._StatusID == ists.StatusID).FirstOrDefault();
                    if (tt1 == null)
                    {
                        timeline.Add(new TimelineSeriesData()
                        {
                            x = ists.StatusName,
                            fillColor = ists.ColorCode,
                            _StatusID = ists.StatusID,
                            y = new List<long>()
                                {
                                    timeline.FirstOrDefault().y[0] // Start === end
                                    , timeline.FirstOrDefault().y[0] // Start === end
                                }
                        });
                    }
                }

                #endregion

                #region Tính % các trạng thái (đơn vị cơ sở tính = mili giây)
                double baseTimeRange_milisecond = (endDate - startDate).TotalMilliseconds;
                long realTotalmiliSeconds = 0;

                List<Common.Data_MachineStatus> listStatusPercent = new List<Data_MachineStatus>();
                foreach (var s in StaticData.Data_MachineStatus)
                {
                    realTotalmiliSeconds = 0;
                    var sPcent = new Data_MachineStatus() { ColorCode = s.ColorCode, StatusID = s.StatusID, StatusName = s.StatusName, StatusDetail = s.StatusDetail };

                    try
                    {
                        var allSt = timeline?.Where(t => t._StatusID == s.StatusID);
                        if (allSt != null && allSt.Any())
                        {
                            foreach (var tempSt in allSt)
                            {
                                realTotalmiliSeconds += (tempSt.y[1] - tempSt.y[0]);
                            }
                        }

                        sPcent.DataPercent = (long)(realTotalmiliSeconds * 100 / baseTimeRange_milisecond);

                    }
                    catch (Exception)
                    {

                    }

                    listStatusPercent.Add(sPcent);
                }


                #endregion


                #endregion

                reval = listStatusPercent ?? new List<Data_MachineStatus>();
            }
            catch (Exception)
            {

            }
            return reval;
        }
    }
}
