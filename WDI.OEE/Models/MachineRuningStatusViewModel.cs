namespace WDI.OEE.Models
{
    public class MachineRuningStatusViewModel
    {
        public MachineRuningStatusViewModel() { }



        public string MachineName { get; set; }
        public string Model { get; set; }
        public string LocationName { get; set; }
        public string Image { get; set; }

        /// <summary>
        /// Danh sách các trạng thái của máy
        /// </summary>
        public List<RuningStatus> ListStatus { get; set; }

        /// <summary>
        /// Danh sách thời gian hoạt động của máy - biểu đồ ngang
        /// </summary>
        public List<Common.Data_MachineStatusHistory> ListStatusHistory { get; set; }
    }

    public class RuningStatus
    {
        public int StatusID { get; set; }
        public string StatusName { get; set; }
        public string ColorCode { get; set; }
        public bool IsActived { get; set; } = false;
    }
}
