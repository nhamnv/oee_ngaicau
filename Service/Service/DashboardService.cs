using Common;
using Common.ViewModels;
using Service.IService;

namespace Service.Service
{
    public class DashboardService : IDashboardService
    {
        public DashboardViewModel GetData(DateTime reportDate)
        {
            // Nếu không chỉ định thời gian thì lấy thời điểm hiện tại
            if ((reportDate == DateTime.MinValue) || (reportDate == DateTime.MaxValue))
            { reportDate = DateTime.Now; }


            DashboardViewModel reval = new DashboardViewModel();

            try
            {
                #region Danh sach may kem trang thai cuoi cung den thoi diem hien tai

                var lstMachineLastStatus =
                    (from m in StaticData.Data_Machine
                     join s in StaticData.Data_MachineLocationSetup on m.MachineID equals s.MachineID
                     join l in StaticData.Data_MachineLocation on s.LocationID equals l.LocationID
                     join h in StaticData.Data_MachineStatusHistory on m.MachineID equals h.MachineID
                                    //new { MachineID = m.MachineID, LocationID = l.LocationID }
                                    //equals
                                    //new { MachineID = h.MachineID, LocationID = h.MachineLocationID } 
                                    into x

                     select new MachineStatus
                     {
                         MachineGroupID = m.MachineGroupID,
                         MachineGroupName = m.MachineGroupName,
                         MachineID = m.MachineID,
                         MachineName = m.MachineName,
                         MachineLocationID = l.LocationID,
                         MachineLocationName = l.LocationName,
                         Model = m.Model,
                         ImageUrl = (!string.IsNullOrEmpty(m.ImageUrl) ? m.ImageUrl : "NoImage.png"),
                         MachineStatusID = x.Where(t => t.StatusTime <= reportDate).OrderByDescending(o => o.StatusTime).FirstOrDefault()?.StatusID ?? 0
                         ,
                         MachineStatusName = (from st in StaticData.Data_MachineStatus
                                              where st.StatusID == (x.Where(t => t.StatusTime <= reportDate).OrderByDescending(o => o.StatusTime).FirstOrDefault()?.StatusID)
                                              select new { st }
                                              ).ToList().FirstOrDefault()?.st.StatusName ?? ""

                     }
                    ).ToList()
                            .OrderBy(t => t.MachineName)
                            .ThenBy(t => t.MachineGroupName)
                            .ThenBy(t => t.MachineLocationName)
                     .Where(t => t.MachineStatusID > 0);

                #endregion

                #region Lấy 6 trạng thái cùng với số liệu theo nhóm máy

                foreach (var s in StaticData.Data_MachineStatus)
                {
                    var sts = new DashboardStatusSummary()
                    {
                        ColorCode = s.ColorCode,
                        StatusName = s.StatusName,
                        StatusID = s.StatusID,
                        StatusDetail = s.StatusDetail
                    };


                    var machinesByStatus = lstMachineLastStatus.Where(t => t.MachineStatusID == s.StatusID);


                    // Count số máy có trạng thái này
                    sts.MachineCount = machinesByStatus?.Count() ?? 0;


                    foreach (var g in StaticData.Data_MachineGroup)
                    {
                        sts.MachineGroups.Add(new MachineGroup()
                        {
                            GroupName = g.MachineGroupName
                            ,
                            GroupID = g.MachineGroupID
                            ,
                            MachineCount = (machinesByStatus?
                                            .Where(t => t.MachineGroupID == g.MachineGroupID)
                                            .Distinct()
                                            .ToList())?.Count ?? 0

                        });
                    }

                    reval.LitStatusSummary.Add(sts);
                }

                #endregion

                #region Lấy danh sách trạng thái các máy

                reval.ListMachineStatus = lstMachineLastStatus?.ToList() ?? new List<MachineStatus>();

                #endregion
            }
            catch (Exception)
            {

            }

            return reval;
        }

        public MachineByStatusGroupDetailViewModel GetMachineByStatusGroupDetail(string MachineStatusID, string MachineGroupID, DateTime reportDate)
        {
            MachineByStatusGroupDetailViewModel reval = new MachineByStatusGroupDetailViewModel();
            try
            {
                int _MachineStatusID = Convert.ToInt32(MachineStatusID);
                int _MachineGroupID = Convert.ToInt32(MachineGroupID);

                reval.MachineStatusID = _MachineStatusID;
                reval.MachineGroupID = _MachineGroupID;
                reval.MachineStatusName = StaticData.Data_MachineStatus.FirstOrDefault(t => t.StatusID == _MachineStatusID)?.StatusName ?? "";
                reval.MachineGroupName = StaticData.Data_MachineGroup.FirstOrDefault(t => t.MachineGroupID == _MachineGroupID)?.MachineGroupName ?? "";
                reval.ColorCode = StaticData.Data_MachineStatus.FirstOrDefault(t => t.StatusID == _MachineStatusID)?.ColorCode ?? "";

                #region Danh sach may kem trang thai cuoi cung den thoi diem hien tai

                var lstMachineLastStatus =
                    (from m in StaticData.Data_Machine
                     join s in StaticData.Data_MachineLocationSetup on m.MachineID equals s.MachineID
                     join l in StaticData.Data_MachineLocation on s.LocationID equals l.LocationID
                     join h in StaticData.Data_MachineStatusHistory on m.MachineID equals h.MachineID into x

                     select new MachineStatus
                     {
                         MachineGroupID = m.MachineGroupID,
                         MachineGroupName = m.MachineGroupName,
                         MachineID = m.MachineID,
                         MachineName = m.MachineName,
                         MachineLocationID = l.LocationID,
                         MachineLocationName = l.LocationName,
                         Model = m.Model,
                         ImageUrl = (!string.IsNullOrEmpty(m.ImageUrl) ? m.ImageUrl : "NoImage.png"),

                         MachineStatusID = x.Where(t => t.StatusTime <= reportDate).OrderByDescending(o => o.StatusTime).FirstOrDefault()?.StatusID ?? 0
                         ,
                         MachineStatusName = (from st in StaticData.Data_MachineStatus
                                              where st.StatusID == (x.Where(t => t.StatusTime <= reportDate).OrderByDescending(o => o.StatusTime).FirstOrDefault()?.StatusID)
                                              select new { st }
                                              ).ToList().FirstOrDefault()?.st.StatusName ?? ""

                     }
                    ).ToList()
                            .OrderBy(t => t.MachineName)
                            .ThenBy(t => t.MachineGroupName)
                            .ThenBy(t => t.MachineLocationName)
                    .Where(t => t.MachineStatusID == _MachineStatusID);

                #endregion

                #region Lấy thông tin trạng thái truyền vào cùng với số liệu theo nhóm máy

                var s1 = StaticData.Data_MachineStatus.Where(t => t.StatusID == _MachineStatusID).FirstOrDefault();
                var sts = new DashboardStatusSummary()
                {
                    ColorCode = s1?.ColorCode ?? "",
                    StatusName = s1?.StatusName ?? "",
                    StatusID = s1?.StatusID ?? 0,
                    StatusDetail = s1?.StatusDetail ?? "",
                };

                var machinesByStatus = lstMachineLastStatus.Where(t => t.MachineStatusID == s1.StatusID);
                // Count số máy có trạng thái này
                sts.MachineCount = machinesByStatus?.Count() ?? 0;

                foreach (var g in StaticData.Data_MachineGroup)
                {
                    sts.MachineGroups.Add(new MachineGroup()
                    {
                        GroupName = g.MachineGroupName
                        ,
                        GroupID = g.MachineGroupID
                        ,
                        MachineCount = (machinesByStatus?
                                        .Where(t => t.MachineGroupID == g.MachineGroupID)
                                        .Distinct()
                                        .ToList())?.Count ?? 0

                    });
                }

                reval.MachineGroups = sts;

                #endregion

                #region Lấy danh sách máy

                reval.ListMachine = lstMachineLastStatus?.Where(t => t.MachineStatusID == _MachineStatusID && t.MachineGroupID == _MachineGroupID)
                    .Select(t => new DashboardMachineItem()
                    {
                        ImageUrl = (!string.IsNullOrEmpty(t.ImageUrl) ? t.ImageUrl : "NoImage.png")
                        ,
                        MachineName = t.MachineName
                        ,
                        MachineID = t.MachineID
                        ,
                        MachineLocationID = t.MachineLocationID
                        ,
                        MachineLocationName = t.MachineLocationName
                        ,
                        Model = t.Model
                    })?.ToList() ?? new List<DashboardMachineItem>();


                #endregion
            }
            catch (Exception)
            {

            }
            return reval;
        }
    }
}

