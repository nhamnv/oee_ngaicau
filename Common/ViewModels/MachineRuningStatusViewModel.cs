namespace Common.ViewModels;

public class MachineRuningStatusViewModel
{
    public MachineRuningStatusViewModel()
    {

    }
    public int MachineID { get; set; }
    public string MachineName { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int MachineLocationID { get; set; }
    public string MachineLocationName { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = "NoImage.jpg";
    public List<Common.Data_MachineStatus> ListStatus = StaticData.Data_MachineStatus;
    public List<Common.Data_MachineStatusHistory> StatusHistories { get; set; } = new List<Common.Data_MachineStatusHistory>();

    /// <summary>
    /// Tự động trích xuất trạng thái hoạt động cuối cùng
    /// </summary>
    public Common.Data_MachineStatus _LastStatus
    {
        get
        {
            Common.Data_MachineStatus result = new Common.Data_MachineStatus();
            try
            {
                if (StatusHistories.Any() && ListStatus.Any())
                {

                    int statusID = StatusHistories?
                        .OrderByDescending(o => o.StatusTime)?
                        .Take(1)?
                        .FirstOrDefault()?.StatusID ?? 0;

                    var reval = ListStatus
                        .Where(s => s.StatusID == statusID)?
                        .ToList()?.FirstOrDefault();

                    result = reval ?? new Data_MachineStatus();
                }
            }
            catch (Exception)
            {
            }

            return result;
        }
    }

    /// <summary>
    /// Tự động trích xuất Trạng thái on-off base trên 5 trạng thái hoạt động khác 
    /// </summary>
    public Common.Data_MachineStatus _CurrentOnOffStatus
    {
        get
        {
            // Default is OFF
            Common.Data_MachineStatus reval = new Data_MachineStatus();
            var obj = StaticData.Data_MachineStatus.Where(t => t.StatusID == 5).FirstOrDefault();
            reval.StatusID = obj?.StatusID ?? 0;
            reval.ColorCode = obj?.ColorCode ?? "";
            reval.StatusName = "Power Off"; // Data gốc là "off"
            reval.StatusDetail = "Đang không vận hành";

            try
            {
                // Khác off (bao gồm nhiều trạng thái) thì là on
                if (_LastStatus != null && _LastStatus.StatusID != 5)
                {
                    var obj2 = StaticData.Data_MachineStatus.Where(t => t.StatusID == 2).FirstOrDefault();
                    reval.StatusID = obj2?.StatusID ?? 0;
                    reval.ColorCode = obj2?.ColorCode ?? "";

                    reval.StatusName = "Power On";// Data gốc là "on"
                    reval.StatusDetail = "Đang sản xuất";
                }
            }
            catch (Exception)
            {

            }

            return reval;
        }
    }

    /// <summary>
    /// Data cho chart timeline
    /// </summary>
    public List<TimelineSeriesData> SeriesTimeLine
    {
        get; set;
        //get
        //{
        //    dynamic reval = null;

        //    try
        //    {
        //        /* Mẫu

        //            series: [
        //            {
        //                data: [
        //                    {
        //                        x: 'Code',
        //                        y: [
        //                            new Date('2024-05-10 01:03:21').getTime(),
        //                            new Date('2024-05-10 03:21:21').getTime(),
        //                        ],
        //                        fillColor: '#008FFB'
        //                    },
        //                    {
        //                        x: 'Code',
        //                        y: [
        //                            new Date('2024-05-10 23:16:21').getTime(),
        //                            new Date('2024-05-10 23:55:21').getTime(),
        //                        ],
        //                        fillColor: '#008FFB'
        //                    },
        //                    {
        //                        x: 'Test',
        //                        y: [
        //                            new Date('2024-05-10 05:09:21').getTime(),
        //                            new Date('2024-05-10 08:31:21').getTime(),
        //                        ],
        //                        fillColor: '#00E396'
        //                    },
        //                    {
        //                        x: 'Validation',
        //                        y: [
        //                            new Date('2024-05-10 11:08:21').getTime(),
        //                            new Date('2024-05-10 13:27:21').getTime(),
        //                        ],
        //                        fillColor: '#FEB019'
        //                    },
        //                    {
        //                        x: 'Deployment',
        //                        y: [
        //                            new Date('2024-05-10 14:56:21').getTime(),
        //                            new Date('2024-05-10 18:19:21').getTime(),
        //                        ],
        //                        fillColor: '#FF4560'
        //                    },
        //                    {
        //                        x: 'DDD',
        //                        y: [
        //                            new Date('2024-05-10 12:08:21').getTime(),
        //                            new Date('2024-05-10 15:27:21').getTime(),
        //                        ],
        //                        fillColor: '#FDB819'
        //                    },
        //                    {
        //                        x: 'CCC',
        //                        y: [
        //                            new Date('2024-05-10 15:56:21').getTime(),
        //                            new Date('2024-05-10 17:19:21').getTime(),
        //                        ],
        //                        fillColor: '#FC4560'
        //                    }
        //                ]
        //            }
        //        ],

        //         */

        //        List<SeriesData> datas = new List<SeriesData>();

        //        #region Populate timeline

        //        foreach (var item in StaticData.Data_MachineStatus)
        //        {
        //            var d = new SeriesData()
        //            {
        //                x = item.StatusName
        //                ,
        //                fillColor = item.ColorCode
        //                ,y =
        //            }
        //        }

        //        #endregion

        //        dynamic data = new
        //        {
        //            series = datas,
        //        };
        //    }
        //    catch (Exception)
        //    {

        //    }

        //    return reval;
        //}
    } = new List<TimelineSeriesData>();

    // Data cho line % các trạng thái
    public List<Common.Data_MachineStatus> ListStatusPercent = new List<Data_MachineStatus>();


}

public class TimelineSeriesData
{


    /// <summary>
    /// Tên hiển thị
    /// </summary>
    public string x { get; set; } = string.Empty;

    /// <summary>
    /// Thời gian total miliseconds tính từ 01/01/1970 đến nay
    /// </summary>
    /// public List<DateTime> y { get; set; } = new List<DateTime>();
    public List<long> y { get; set; } = new List<long>();

    /// <summary>
    /// Màu hiển thị barChart
    /// </summary>
    public string fillColor { get; set; } = string.Empty;

    /// <summary>
    /// Trường để tính toán
    /// </summary>
    public int _StatusID { get; set; } = 0;
}