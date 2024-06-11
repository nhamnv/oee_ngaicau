namespace Common.ViewModels
{
    public class DashboardViewModel
    {
        public List<MachineStatus> ListMachineStatus { get; set; } = new List<MachineStatus>();

        public List<DashboardStatusSummary> LitStatusSummary { get; set; } = new List<DashboardStatusSummary>();
    }

    public class DashboardStatusSummary
    {
        public string StatusName { get; set; } = string.Empty;
        public string StatusDetail { get; set; } = string.Empty;
        public int StatusID { get; set; } = 0;
        public string ColorCode { get; set; } = string.Empty;

        public int MachineCount { get; set; } = 0;

        public List<MachineGroup> MachineGroups { get; set; } = new List<MachineGroup>();
    }

    public class MachineGroup
    {
        public int GroupID { get; set; } = 0;
        public string GroupName { get; set; } = string.Empty;
        public int MachineCount { get; set; }
    }

    public class MachineStatus
    {
        public int MachineGroupID { get; set; }
        public string MachineGroupName { get; set; } = string.Empty;

        public int MachineLocationID { get; set; }
        public string MachineLocationName { get; set; } = string.Empty;

        public int MachineID { get; set; }
        public string MachineName { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;


        public int MachineStatusID { get; set; }
        public string MachineStatusName { get; set; } = string.Empty;
    }
}
