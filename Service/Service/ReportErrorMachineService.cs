using Common;
using Service.IService;

namespace Service.Service
{
    public class ReportErrorMachineService : IErrorMachineService
    {
        public ReportErrorMachineService()
        {

        }
        /// <summary>
        /// Lấy danh sách lỗi
        /// </summary>
        /// <returns></returns>
        public IEnumerable<dynamic> GetErrorList(string TimeRangeID, string MachineGroupID, string MachineLocationID)
        {
            // Table structure: Ngày | Vị trí | Thiết bị | Nhóm máy | Mã lỗi | Tên lỗi | Ghi chú

            List<dynamic> reval = new List<dynamic>();
            List<dynamic> revalFiltered = new List<dynamic>();

            try
            {
                var data = from his in StaticData.Data_ErrorHistory
                           join machine in StaticData.Data_Machine
                                   on his.MachineID equals machine.MachineID
                           join err in StaticData.Data_Error
                                   on his.ErrorID equals err.ID
                           join msetup in StaticData.Data_MachineLocationSetup
                                   on his.MachineID equals msetup.MachineID
                           join loc in StaticData.Data_MachineLocation
                                   on msetup.LocationID equals loc.LocationID

                           // Where
                           select new
                           {
                               ErrorDate = his.ErrorDate
                               ,
                               MachineLocation = loc.LocationName
                               ,
                               MachineName = machine.MachineName
                               ,
                               MachineGroupName = machine.MachineGroupName
                               ,
                               ErrorCode = err.ErrorCode
                               ,
                               ErrorName = err.ErrorName
                               // For filter
                               ,
                               MachineGroupID = machine.MachineGroupID
                               ,
                               MachineLocationID = msetup.LocationID
                           } as dynamic;

                revalFiltered = data?.ToList() ?? new List<dynamic>();


                #region Filter


                if (!string.IsNullOrEmpty(TimeRangeID) && TimeRangeID.ToLower() != "all")
                {
                    var d = DateTime.Now;
                    var startDate = DateTime.Now;
                    var endDate = DateTime.Now;
                    int quarter = (d.AddMonths(-3).Month + 2) / 3;


                    switch (TimeRangeID)
                    {
                        case "1": // Last month
                            startDate = new DateTime(d.Year, d.Month - 1, 1);
                            endDate = new DateTime(d.Year, d.Month - 1, DateTime.DaysInMonth(startDate.Year, startDate.Month));
                            break;
                        case "2":// Last quarter
                            d = d.AddMonths(-3);

                            if (quarter == 1) // 123
                            {
                                startDate = new DateTime(d.Year, 1, 1);
                                endDate = new DateTime(d.Year, 3, DateTime.DaysInMonth(startDate.Year, 3));
                            }
                            else if (quarter == 2) // 456
                            {
                                startDate = new DateTime(d.Year, 4, 1);
                                endDate = new DateTime(d.Year, 6, DateTime.DaysInMonth(startDate.Year, 6));
                            }
                            else if (quarter == 3) // 789
                            {
                                startDate = new DateTime(d.Year, 7, 1);
                                endDate = new DateTime(d.Year, 9, DateTime.DaysInMonth(startDate.Year, 9));
                            }
                            else if (quarter == 4) // 101112
                            {
                                startDate = new DateTime(d.Year, 10, 1);
                                endDate = new DateTime(d.Year, 12, DateTime.DaysInMonth(startDate.Year, 12));
                            }
                            break;
                        case "3":// Last year
                            startDate = new DateTime(d.Year - 1, 1, 1);
                            endDate = new DateTime(d.Year - 1, 12, 31);
                            break;
                        case "4":// this month
                            startDate = new DateTime(d.Year, d.Month, 1);
                            endDate = new DateTime(d.Year, d.Month, DateTime.DaysInMonth(startDate.Year, startDate.Month));
                            break;
                        case "5":// this quarter
                            if (quarter == 1) // 123
                            {
                                startDate = new DateTime(d.Year, 1, 1);
                                endDate = new DateTime(d.Year, 3, DateTime.DaysInMonth(startDate.Year, 3));
                            }
                            else if (quarter == 2) // 456
                            {
                                startDate = new DateTime(d.Year, 4, 1);
                                endDate = new DateTime(d.Year, 6, DateTime.DaysInMonth(startDate.Year, 6));
                            }
                            else if (quarter == 3) // 789
                            {
                                startDate = new DateTime(d.Year, 7, 1);
                                endDate = new DateTime(d.Year, 9, DateTime.DaysInMonth(startDate.Year, 9));
                            }
                            else if (quarter == 4) // 101112
                            {
                                startDate = new DateTime(d.Year, 10, 1);
                                endDate = new DateTime(d.Year, 12, DateTime.DaysInMonth(startDate.Year, 12));
                            }
                            break;
                        case "6":// this year
                            startDate = new DateTime(d.Year, 1, 1);
                            endDate = new DateTime(d.Year, 12, 31);
                            break;
                        default:
                            break;
                    }


                    revalFiltered = revalFiltered.Where(t => t.ErrorDate >= startDate && t.ErrorDate <= endDate).ToList();
                }
                if (!string.IsNullOrEmpty(MachineGroupID) && MachineGroupID.ToLower() != "all")
                {
                    revalFiltered = revalFiltered?.Where(t => t.MachineGroupID?.ToString() == MachineGroupID)?.ToList() ?? new List<dynamic>();
                }
                if (!string.IsNullOrEmpty(MachineLocationID) && MachineLocationID.ToLower() != "all")
                {
                    revalFiltered = revalFiltered?.Where(t => t.MachineLocationID?.ToString() == MachineLocationID).ToList() ?? new List<dynamic>();
                }
                #endregion

            }
            catch (Exception)
            {

            }

            return revalFiltered;
        }

        /// <summary>
        /// Lấy danh sách lỗi
        /// </summary>
        /// <returns></returns>
        public IEnumerable<dynamic> GetErrorListByMachineID(int machineID)
        {
            // Table structure: Ngày | Vị trí | Thiết bị | Nhóm máy | Mã lỗi | Tên lỗi | Ghi chú

            List<dynamic> reval = new List<dynamic>();
            List<dynamic> revalFiltered = new List<dynamic>();

            try
            {
                var data = from his in StaticData.Data_ErrorHistory
                           join machine in StaticData.Data_Machine
                                   on his.MachineID equals machine.MachineID
                           join err in StaticData.Data_Error
                                   on his.ErrorID equals err.ID
                           join msetup in StaticData.Data_MachineLocationSetup
                                   on his.MachineID equals msetup.MachineID
                           join loc in StaticData.Data_MachineLocation
                                   on msetup.LocationID equals loc.LocationID

                           where machine.MachineID == machineID
                           select new
                           {
                               ErrorDate = his.ErrorDate
                               ,
                               MachineLocation = loc.LocationName
                               ,
                               MachineName = machine.MachineName
                               ,
                               MachineGroupName = machine.MachineGroupName
                               ,
                               ErrorCode = err.ErrorCode
                               ,
                               ErrorName = err.ErrorName
                               // For filter
                               ,
                               MachineGroupID = machine.MachineGroupID
                               ,
                               MachineLocationID = msetup.LocationID
                           } as dynamic;

                revalFiltered = data?.ToList() ?? new List<dynamic>();
            }
            catch (Exception)
            {

            }

            return revalFiltered;
        }


        public dynamic GetTop10ErrorList(string TimeRangeID, string MachineGroupID, string MachineLocationID)
        {
            dynamic result = "";
            // Table structure: Ngày | Vị trí | Thiết bị | Nhóm máy | Mã lỗi | Tên lỗi | Ghi chú

            List<dynamic> reval = new List<dynamic>();
            List<dynamic> revalFiltered = new List<dynamic>();

            try
            {
                var data = from his in StaticData.Data_ErrorHistory
                           join machine in StaticData.Data_Machine
                                   on his.MachineID equals machine.MachineID
                           join err in StaticData.Data_Error
                                   on his.ErrorID equals err.ID
                           join msetup in StaticData.Data_MachineLocationSetup
                                   on his.MachineID equals msetup.MachineID
                           join loc in StaticData.Data_MachineLocation
                                   on msetup.LocationID equals loc.LocationID

                           // Where
                           select new
                           {
                               ErrorDate = his.ErrorDate
                               ,
                               MachineLocation = loc.LocationName
                               ,
                               MachineName = machine.MachineName
                               ,
                               MachineGroupName = machine.MachineGroupName
                               ,
                               ErrorCode = err.ErrorCode
                               ,
                               ErrorName = err.ErrorName
                               // For filter
                               ,
                               MachineGroupID = machine.MachineGroupID
                               ,
                               MachineLocationID = msetup.LocationID
                           } as dynamic;

                revalFiltered = data?.ToList() ?? new List<dynamic>();


                #region Filter


                if (!string.IsNullOrEmpty(TimeRangeID) && TimeRangeID.ToLower() != "all")
                {
                    var d = DateTime.Now;
                    var startDate = DateTime.Now;
                    var endDate = DateTime.Now;
                    int quarter = (d.AddMonths(-3).Month + 2) / 3;


                    switch (TimeRangeID)
                    {
                        case "1": // Last month
                            startDate = new DateTime(d.Year, d.Month - 1, 1);
                            endDate = new DateTime(d.Year, d.Month - 1, DateTime.DaysInMonth(startDate.Year, startDate.Month));
                            break;
                        case "2":// Last quarter
                            d = d.AddMonths(-3);

                            if (quarter == 1) // 123
                            {
                                startDate = new DateTime(d.Year, 1, 1);
                                endDate = new DateTime(d.Year, 3, DateTime.DaysInMonth(startDate.Year, 3));
                            }
                            else if (quarter == 2) // 456
                            {
                                startDate = new DateTime(d.Year, 4, 1);
                                endDate = new DateTime(d.Year, 6, DateTime.DaysInMonth(startDate.Year, 6));
                            }
                            else if (quarter == 3) // 789
                            {
                                startDate = new DateTime(d.Year, 7, 1);
                                endDate = new DateTime(d.Year, 9, DateTime.DaysInMonth(startDate.Year, 9));
                            }
                            else if (quarter == 4) // 101112
                            {
                                startDate = new DateTime(d.Year, 10, 1);
                                endDate = new DateTime(d.Year, 12, DateTime.DaysInMonth(startDate.Year, 12));
                            }
                            break;
                        case "3":// Last year
                            startDate = new DateTime(d.Year - 1, 1, 1);
                            endDate = new DateTime(d.Year - 1, 12, 31);
                            break;
                        case "4":// this month
                            startDate = new DateTime(d.Year, d.Month, 1);
                            endDate = new DateTime(d.Year, d.Month, DateTime.DaysInMonth(startDate.Year, startDate.Month));
                            break;
                        case "5":// this quarter
                            if (quarter == 1) // 123
                            {
                                startDate = new DateTime(d.Year, 1, 1);
                                endDate = new DateTime(d.Year, 3, DateTime.DaysInMonth(startDate.Year, 3));
                            }
                            else if (quarter == 2) // 456
                            {
                                startDate = new DateTime(d.Year, 4, 1);
                                endDate = new DateTime(d.Year, 6, DateTime.DaysInMonth(startDate.Year, 6));
                            }
                            else if (quarter == 3) // 789
                            {
                                startDate = new DateTime(d.Year, 7, 1);
                                endDate = new DateTime(d.Year, 9, DateTime.DaysInMonth(startDate.Year, 9));
                            }
                            else if (quarter == 4) // 101112
                            {
                                startDate = new DateTime(d.Year, 10, 1);
                                endDate = new DateTime(d.Year, 12, DateTime.DaysInMonth(startDate.Year, 12));
                            }
                            break;
                        case "6":// this year
                            startDate = new DateTime(d.Year, 1, 1);
                            endDate = new DateTime(d.Year, 12, 31);
                            break;
                        default:
                            break;
                    }


                    revalFiltered = revalFiltered.Where(t => t.ErrorDate >= startDate && t.ErrorDate <= endDate).ToList();
                }
                if (!string.IsNullOrEmpty(MachineGroupID) && MachineGroupID.ToLower() != "all")
                {
                    revalFiltered = revalFiltered.Where(t => t.MachineGroupID?.ToString() == MachineGroupID).ToList();
                }
                if (!string.IsNullOrEmpty(MachineLocationID) && MachineLocationID.ToLower() != "all")
                {
                    revalFiltered = revalFiltered.Where(t => t.MachineLocationID?.ToString() == MachineLocationID).ToList();
                }
                #endregion



                // Bảng top 10
                var TableTop10Error = (revalFiltered?
                       .GroupBy(t => new { t.ErrorName, t.ErrorCode })
                       .OrderByDescending(o => o.Count())
                       .Take(10)
                       .Select(s => new
                       {
                           ErrorName = s.Key.ErrorName,
                           ErrorCode = s.Key.ErrorCode,
                           ErrorCount = s.Count()
                       }
                   ) as dynamic);

                string ErrorMostOccus = "";
                string ErrorLeastOccus = "";
                int ErrorTotal = 0;


                ErrorMostOccus = revalFiltered?
                        .GroupBy(t => t.ErrorName)?
                        .OrderByDescending(o => o.Count())?
                        .Take(1)?
                        .Select(s => new { ErrorName = s.Key })?.ToList()?.FirstOrDefault()?.ErrorName ?? "";

                ErrorLeastOccus = revalFiltered?
                        .GroupBy(t => t.ErrorName)
                        .OrderBy(o => o.Count())
                        .Take(1)
                        .Select(s => new { ErrorName = s.Key }).ToList()?.FirstOrDefault()?.ErrorName ?? "";

                ErrorTotal = revalFiltered?.Count ?? 0;

                result = new
                {
                    ErrorMostOccus = ErrorMostOccus,
                    ErrorLeastOccus = ErrorLeastOccus,
                    TableTop10Error = TableTop10Error,
                    ErrorTotal = ErrorTotal
                };

            }
            catch (Exception)
            {

            }



            return result;
        }



        private DateTime _RandomDate()
        {
            var date = new DateTime(2014, 1, 1);
            Random random = new Random();

            date = date.AddMonths(random.Next(1, 10));
            date = date.AddMonths(random.Next(1, 28));
            date = date.AddDays(random.Next(1, 10));
            date = date.AddHours(random.Next(1, 12));
            date = date.AddMinutes(random.Next(1, 60));
            date = date.AddSeconds(random.Next(1, 60));
            date = date.AddMicroseconds(random.Next(1, 1000));

            return date;
        }
    }
}
