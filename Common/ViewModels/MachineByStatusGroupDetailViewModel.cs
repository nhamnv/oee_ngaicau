namespace Common.ViewModels
{
    public class MachineByStatusGroupDetailViewModel
    {
        /// <summary>
        /// Current MachineStatusId
        /// </summary>
        public int MachineStatusID { get; set; }

        public string MachineStatusName { get; set; } = string.Empty;
        public string ColorCode { get; set; } = string.Empty;

        /// <summary>
        /// Current MachineGroupId
        /// </summary>
        public int MachineGroupID { get; set; }

        public string MachineGroupName { get; set; } = string.Empty;

        /// <summary>
        /// Danh sách nhóm máy
        /// </summary>
        public DashboardStatusSummary MachineGroups { get; set; } = new DashboardStatusSummary();

        /// <summary>
        /// Danh sách máy của group
        /// </summary>
        public List<DashboardMachineItem> ListMachine { get; set; } = new List<DashboardMachineItem> { };
    }

    public class DashboardMachineItem
    {
        public int MachineID { get; set; }
        public string MachineName { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int MachineLocationID { get; set; }
        public string MachineLocationName { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
    }
}
