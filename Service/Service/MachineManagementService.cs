using Common;
using Common.ViewModels;
using Service.IService;

namespace Service.Service
{
    public class MachineManagementService : IMachineManagementService
    {


        public MachineStatiticsViewModel GetStatitics()
        {
            MachineStatiticsViewModel reval = new MachineStatiticsViewModel();

            #region Fake data

            // Box - Số nhà xưởng
            //reval.BoxTotalWorkshop = new BoxData()
            //{
            //    Title = "Số nhà xưởng",
            //    Value = 3,
            //    Data = new List<ChartItemViewModel>()
            //};

            #region // Box - Tổng số máy
            reval.BoxTotalMachine = new BoxData()
            {
                Title = "Số máy theo phân loại",
                Value = (from m in StaticData.Data_Machine
                         select m.Quantity).Sum() //StaticData.Data_Machine.Count,
            };
            for (int i = 0; i < StaticData.Data_AssetGroup.Count; i++)
            {
                var asset = StaticData.Data_AssetGroup[i];

                reval.BoxTotalMachine.Data.Add(
                new ChartItemViewModel()
                {
                    DataID = asset.AssetGroupID
                    ,
                    Name = asset.AssetGroupName
                    ,
                    ColorCode = asset.ColorCode
                    ,
                    Value = (from m in StaticData.Data_Machine
                             where m.AssetGroupID == asset.AssetGroupID
                             select m.Quantity
                             )
                             .Sum()
                });
            }
            #endregion

            #region // Box - Số máy theo nhóm
            reval.BoxTotalMachineByGroup = new BoxData()
            {
                Title = "Số máy theo nhóm",
                Value = (from m in StaticData.Data_Machine
                         select m.Quantity).Sum(),
            };
            for (int i = 0; i < StaticData.Data_MachineGroup.Count; i++)
            {
                var group = StaticData.Data_MachineGroup[i];

                reval.BoxTotalMachineByGroup.Data.Add(
                new ChartItemViewModel()
                {
                    DataID = group.MachineGroupID
                    ,
                    Name = group.MachineGroupName
                    ,
                    Value = (from m in StaticData.Data_Machine
                             where m.MachineGroupID == @group.MachineGroupID
                             select m.Quantity
                             )
                             .Sum()
                });
            }
            #endregion


            #region // Pie Chart - Tỷ lệ máy theo phân loại
            reval.PieChartRateOfTotalMachineByWorkshop = new ChartData()
            {
                Title = "Tỷ lệ máy theo phân loại",
            };
            for (int i = 0; i < StaticData.Data_AssetGroup.Count; i++)
            {
                var asset = StaticData.Data_AssetGroup[i];

                reval.PieChartRateOfTotalMachineByWorkshop.Data.Add(
                        new ChartItemViewModel()
                        {
                            DataID = asset.AssetGroupID
                            ,
                            Name = asset.AssetGroupName
                            ,
                            ColorCode = asset.ColorCode
                            ,
                            Value = ((from h in StaticData.Data_MachineStatusHistory
                                      join m in StaticData.Data_Machine on h.MachineID equals m.MachineID
                                      where m.AssetGroupID == asset.AssetGroupID
                                      select m.MachineID
                                     )
                                     .ToList()
                                     .Distinct()
                                     .Count()
                                     )
                                     * 100
                                     /
                                     StaticData.Data_Machine.Count
                        });
            }

            #endregion




            #region // Pie Chart - Tỷ lệ máy theo nhóm máy
            reval.PieChartRateOfTotalMachineByGroup = new ChartData()
            {
                Title = "Tỷ lệ máy theo nhóm máy",
            };
            for (int i = 0; i < StaticData.Data_MachineGroup.Count; i++)
            {
                var group = StaticData.Data_MachineGroup[i];

                reval.PieChartRateOfTotalMachineByGroup.Data.Add(
                            new ChartItemViewModel()
                            {
                                DataID = group.MachineGroupID
                                ,
                                Name = group.MachineGroupName
                                ,
                                ColorCode = group.ColorCode
                                ,
                                Value = ((from h in StaticData.Data_MachineStatusHistory
                                          join m in StaticData.Data_Machine on h.MachineID equals m.MachineID
                                          where m.MachineGroupID == @group.MachineGroupID
                                          select m.MachineID
                                         )
                                         .ToList()
                                         .Distinct()
                                         .Count()
                                         )
                                         * 100
                                         /
                                         StaticData.Data_Machine.Count
                            });
            }

            #endregion


            // Pie Chart - Tỷ lệ máy theo nhóm tài sản
            reval.PieChartRateOfTotalMachineByAssetGroup = new ChartData()
            {
                Title = "Tỷ lệ máy theo nhóm tài sản",
                Data = new List<ChartItemViewModel>()
                {
                    new ChartItemViewModel() {Name="Máy cắt", Value=18.6, ColorCode="#e17084", DataID = 1},
                    new ChartItemViewModel() {Name="Máy cưa", Value=2.33, ColorCode="#6aa1e4", DataID = 2},
                    new ChartItemViewModel() {Name="Máy khoan", Value=4.65, ColorCode="#f1cf6d", DataID = 3},
                    new ChartItemViewModel() {Name="Máy phay", Value=6.98, ColorCode="#73c84f", DataID = 4},
                    new ChartItemViewModel() {Name="Máy lốc, uốn, gấp mép, xoay ống", Value=4.65, ColorCode="#df4d26", DataID = 5},
                    new ChartItemViewModel() {Name="Máy ráp dầm, H/I-Đính, Gá, Lật, VC dầm", Value=23.26, ColorCode="#6798f7", DataID = 6},
                    new ChartItemViewModel() {Name="Máy nắn thẳng", Value=4.65, ColorCode="#5c360f", DataID = 7},
                    new ChartItemViewModel() {Name="Máy hàn cổng", Value=34.88, ColorCode="#696796", DataID = 8}
                }
            };


            // Table - Thống kê theo nhóm máy và xưởng -- Cần làm lại số liệu nhé
            reval.BarChartListMachineByGroupAndWorkshop = new BarChart()
            {
                Title = "Thống kê theo nhóm máy và xưởng sản xuất",
                Data = new List<ChartData>()
                {
                    new ChartData()
                    {
                        Title="AH1",
                        ColorCode="#E17084",
                        Data = new List<ChartItemViewModel>()
                        {
                            new ChartItemViewModel() {Name="GCN", Value=2,      ColorCode="#E17084", DataID=1},
                            new ChartItemViewModel() {Name="DCTH", Value=9,     ColorCode="#6aa1e4", DataID=1},
                            new ChartItemViewModel() {Name="LASER", Value=7,    ColorCode="#f1cf6d", DataID=1},
                            new ChartItemViewModel() {Name="PLASMA", Value=11,  ColorCode="#73c84f", DataID=1},
                            new ChartItemViewModel() {Name="ROBOT", Value=4,    ColorCode="#df4d26", DataID=1},
                        }
                    },
                    new ChartData()
                    {
                        Title="AH2",
                        ColorCode="#6aa1e4",
                        Data = new List<ChartItemViewModel>()
                        {
                            new ChartItemViewModel() {Name="GCN", Value=14,     ColorCode="#E17084", DataID=2},
                            new ChartItemViewModel() {Name="DCTH", Value=3,     ColorCode="#6aa1e4", DataID=2},
                            new ChartItemViewModel() {Name="LASER", Value=4,    ColorCode="#f1cf6d", DataID=2},
                            new ChartItemViewModel() {Name="PLASMA", Value=9,   ColorCode="#73c84f", DataID=2},
                            new ChartItemViewModel() {Name="ROBOT", Value=12,   ColorCode="#df4d26", DataID=2},
                        }
                    },
                    new ChartData()
                    {
                        Title="AH3",
                        ColorCode="#f1cf6d",
                        Data = new List<ChartItemViewModel>()
                        {
                            new ChartItemViewModel() {Name="GCN", Value=6,      ColorCode="#E17084", DataID=3},
                            new ChartItemViewModel() {Name="DCTH", Value=1,     ColorCode="#6aa1e4", DataID=3},
                            new ChartItemViewModel() {Name="LASER", Value=0,    ColorCode="#f1cf6d", DataID=3},
                            new ChartItemViewModel() {Name="PLASMA", Value=2,   ColorCode="#73c84f", DataID=3},
                            new ChartItemViewModel() {Name="ROBOT", Value=0,    ColorCode="#df4d26", DataID=3},
                        }
                    },
                }
            };

            // Table - Thống kê theo nhóm máy và xưởng 2  -- Cần làm lại số liệu nhé
            reval.BarChartListMachineByGroupAndWorkshop2 = new BarChart()
            {
                Title = "Thống kê theo nhóm máy và xưởng sản xuất",
                Data = new List<ChartData>()
                {
                    new ChartData()
                    {
                        Title="GCN",
                        ColorCode ="#E17084",
                        Data = new List<ChartItemViewModel>()
                        {
                            new ChartItemViewModel() {Name="AH1", Value=14, ColorCode="#E17084", DataID=1},
                            new ChartItemViewModel() {Name="AH2", Value=17, ColorCode="#6aa1e4", DataID=1},
                            new ChartItemViewModel() {Name="AH3", Value=6,  ColorCode="#f1cf6d", DataID=1}
                        }
                    },
                    new ChartData()
                    {
                        Title="DCTH",
                        ColorCode ="#6aa1e4",
                        Data = new List<ChartItemViewModel>()
                        {
                            new ChartItemViewModel() {Name="AH1", Value=3,  ColorCode="#E17084", DataID=2},
                            new ChartItemViewModel() {Name="AH2", Value=6,  ColorCode="#6aa1e4", DataID=2},
                            new ChartItemViewModel() {Name="AH3", Value=15, ColorCode="#f1cf6d", DataID=2}
                        }
                    },
                    new ChartData()
                    {
                        Title="LASER",
                        ColorCode ="#f1cf6d",
                        Data = new List<ChartItemViewModel>()
                        {
                            new ChartItemViewModel() {Name="AH1", Value=12, ColorCode="#E17084", DataID=3},
                            new ChartItemViewModel() {Name="AH2", Value=4,  ColorCode="#6aa1e4", DataID=3},
                            new ChartItemViewModel() {Name="AH3", Value=18, ColorCode="#f1cf6d", DataID=3}
                        }
                    },
                    new ChartData()
                    {
                        Title="PLASMA",
                        ColorCode ="#73c84f",
                        Data = new List<ChartItemViewModel>()
                        {
                            new ChartItemViewModel() {Name="AH1", Value=8,  ColorCode="#E17084", DataID=4},
                            new ChartItemViewModel() {Name="AH2", Value=16, ColorCode="#6aa1e4", DataID=4},
                            new ChartItemViewModel() {Name="AH3", Value=1,  ColorCode="#f1cf6d", DataID=4}
                        }
                    },
                    new ChartData()
                    {
                        Title="ROBOT",
                        ColorCode ="#df4d26",
                        Data = new List<ChartItemViewModel>()
                        {
                            new ChartItemViewModel() {Name="AH1", Value=27, ColorCode="#E17084", DataID=5},
                            new ChartItemViewModel() {Name="AH2", Value=4,  ColorCode="#6aa1e4", DataID=5},
                            new ChartItemViewModel() {Name="AH3", Value=18, ColorCode="#f1cf6d", DataID=5}
                        }
                    },
                }
            };

            #endregion

            #region Biểu đồ tròn tỷ lệ số máy theo trạng thái hoạt động PieChartRateOfTotalMachineByStatus
            reval.PieChartRateOfTotalMachineByStatus = new ChartData()
            {
                Title = "Tổng hợp tình trạng hoạt động của các máy",
                Data = new List<ChartItemViewModel>()
            };
            foreach (var s in StaticData.Data_MachineStatus)
            {
                reval.PieChartRateOfTotalMachineByStatus.Data.Add(new ChartItemViewModel
                {
                    DataID = s.StatusID,
                    Name = s.StatusDetail,
                    ColorCode = s.ColorCode,
                    // Tỷ lệ phải tính trong bảng StatusHistory
                    Value =
                    (
                        (StaticData.Data_MachineStatusHistory
                            .Where(t => t.StatusID == s.StatusID)?
                            .ToList()
                            .Select(s1 => s1.MachineID)
                            .Distinct()
                            .Count() ?? 0)
                        * 100
                        /
                        (StaticData.Data_MachineStatusHistory
                            .Select(s => s.MachineID)?
                            .Distinct()
                            .Count() ?? 1)
                    )
                });
            }
            #endregion

            #region Biểu đồ barChart tình trạng hoạt động của các máy theo nhóm máy - BarChartListMachineStatusByGroup

            reval.BarChartListMachineStatusByGroup = new BarChart()
            {
                Title = "Tình trạng hoạt động của các máy theo nhóm máy",
                Data = new List<ChartData>()
            };

            foreach (var s in StaticData.Data_MachineStatus)
            {
                var d = new ChartData()
                {
                    Title = s.StatusDetail,
                    ColorCode = s.ColorCode,
                    Data = new List<ChartItemViewModel>()
                };
                foreach (var mGroup in StaticData.Data_MachineGroup)
                {
                    d.Data.Add(new ChartItemViewModel()
                    {
                        Name = mGroup.MachineGroupName,
                        // Value = số máy có trạng thái cha
                        Value = ((
                            from h in StaticData.Data_MachineStatusHistory
                            join m in StaticData.Data_Machine
                                    on h.MachineID equals m.MachineID
                            where (h.StatusID == s.StatusID && m.MachineGroupID == mGroup.MachineGroupID)
                            select new { h.MachineID }
                            )
                            .ToList()
                            .Distinct()
                            .Count()
                            ),
                        // ColorCode = "#E17084", Bỏ qua màu vì màu ăn theo màu nhóm cha bên ngoài
                        DataID = s.StatusID // ID của item cha
                    });
                }
                reval.BarChartListMachineStatusByGroup.Data.Add(d);
            }
            #endregion

            return reval;
        }

        public MachineDetailViewModel GetDetails(int machineID, int machineLocationID)
        {
            MachineDetailViewModel reval = new MachineDetailViewModel();

            try
            {
                reval.Machine = (from m in StaticData.Data_Machine
                                 where m.MachineID == machineID
                                 select new Common.Data_Machine()
                                 {
                                     MachineID = machineID,
                                     AccountantCode = m.AccountantCode,
                                     AssetGroupID = m.AssetGroupID,
                                     AssetGroupName = m.AssetGroupName,
                                     BaseUnitID = m.BaseUnitID,
                                     BaseUnitName = m.BaseUnitName,
                                     FirstUseDate = m.FirstUseDate,
                                     MachineAssetCode = m.MachineAssetCode,
                                     MachineGroupID = m.MachineGroupID,
                                     MachineGroupName = m.MachineGroupName,
                                     MachineLocationID = m.MachineLocationID,
                                     MachineLocationName = m.MachineLocationName,
                                     MachineName = m.MachineName,
                                     Model = m.Model,
                                     ProviderID = m.ProviderID,
                                     ProviderName = m.ProviderName,
                                     SerialNo = m.SerialNo,
                                     ImageUrl = m.ImageUrl,
                                     ListComponents = m.ListComponents,
                                 })?.FirstOrDefault() ?? new Data_Machine();
            }
            catch (Exception)
            {

            }
            return reval;
        }

        public List<Data_RepaireHistory> GetMachineRepaireHistory(int machineID)
        {
            List<Data_RepaireHistory> reval = new List<Data_RepaireHistory>();
            try
            {
                return StaticData.Data_RepaireHistory.Where(t => t.MachineID == machineID)?.OrderByDescending(o => o.DateFinishTask)?.ToList() ?? new List<Data_RepaireHistory>();
            }
            catch (Exception)
            {

            }
            return reval;
        }

        public List<Data_MachineMaintenanceList> GetMachineMaintenanceList(int machineID)
        {
            List<Data_MachineMaintenanceList> reval = new List<Data_MachineMaintenanceList>();
            try
            {
                reval = StaticData.Data_MachineMaintenanceList.Where(t => t.MachineID == machineID).ToList();
            }
            catch (Exception)
            {

            }
            return reval;
        }


        public List<dynamic> GetMachineStatusList()
        {
            List<dynamic> reval = new List<dynamic>();
            try
            {
                /*
                FROM Data_Machine m
                INNER JOIN Data_AssetGroup ag ON ag.Id = m.AssetGroupID
                INNER JOIN Data_MachineGroup mg ON mg.ID = m.MachineGroupID
                INNER JOIN Data_Location l On l.ID = m.MachineLocationID
                INNER JOIN Data_BaseUnit bu ON bu.Id = m.BaseUnitID
                INNER JOIN Data_Workshop ws ON ws.id=l.WorkshopID
                INNER JOIN Data_Factory f ON f.ID= l.FactoryID                 
                 */
                var lst = from h in StaticData.Data_MachineStatusHistory
                          join m in StaticData.Data_Machine on h.MachineID equals m.MachineID
                          join s in StaticData.Data_MachineStatus on h.StatusID equals s.StatusID
                          select new
                          {
                              m.MachineID
                              ,
                              m.MachineName
                              ,
                              m.MachineGroupName
                              ,
                              m.Model
                              ,
                              h.StatusID
                              ,
                              s.StatusName
                              ,
                              s.StatusDetail
                              ,
                              s.ColorCode
                          };
                reval = lst?.ToList<dynamic>();
            }
            catch (Exception)
            {

            }
            return reval;
        }

        public List<dynamic> GetListMachine()
        {
            List<dynamic> reval = new List<dynamic>();
            try
            {
                /*
                FROM Data_Machine m
                INNER JOIN Data_AssetGroup ag ON ag.Id = m.AssetGroupID
                INNER JOIN Data_MachineGroup mg ON mg.ID = m.MachineGroupID
                INNER JOIN Data_Location l On l.ID = m.MachineLocationID
                INNER JOIN Data_BaseUnit bu ON bu.Id = m.BaseUnitID
                INNER JOIN Data_Workshop ws ON ws.id=l.WorkshopID
                INNER JOIN Data_Factory f ON f.ID= l.FactoryID                 
                 */
                var lst = from m in StaticData.Data_Machine
                          join h in StaticData.Data_MachineStatusHistory on m.MachineID equals h.MachineID
                                    into x
                          join s in StaticData.Data_MachineStatus on x.FirstOrDefault()?.StatusID equals s.StatusID
                          //////join f in StaticData.Data_F on f.ID = l.FactoryID

                          select new
                          {
                              m.MachineID
                              ,
                              m.MachineName
                              ,
                              m.MachineGroupName
                              ,
                              m.MachineGroupID
                              ,
                              m.Model
                              ,
                              x.FirstOrDefault()?.StatusID
                              ,
                              s.StatusName
                              ,
                              s.StatusDetail
                              ,
                              s.ColorCode
                              ,
                              m.Quantity
                              // Thêm
                              ,
                              m.AccountantCode
                              ,
                              m.AssetGroupID
                              ,
                              m.AssetGroupName
                              ,
                              m.BaseUnitID
                              ,
                              m.BaseUnitName
                              // m.factoryID
                              ,
                              m.FirstUseDate
                              ,
                              m.MachineAssetCode
                              ,
                              m.MachineLocationID
                              ,
                              m.MachineLocationName
                              ,
                              m.ProviderID
                              ,
                              m.ProviderName
                              ,
                              m.Note
                              //,workshopID
                              //,
                              //workshopName


                          };
                reval = lst?.ToList<dynamic>();
            }
            catch (Exception)
            {

            }
            return reval;
        }
    }
}
