using Common.ViewModels;

namespace Service.IService
{
    public interface IReportMachineRuningStatusService
    {
        List<MachineRuningStatusViewModel> GetReportMachineRuningStatus(DateTime StartDate, DateTime EndDate, string MachineGroupID, string MachineLocationID, string MachineID = "");

        /// <summary>
        /// Dữ liệu biểu đồ thời gian máy chạy - theo máy cụ thể
        /// </summary>
        /// <param name="machineID"></param>
        /// <returns></returns>
        List<TimelineSeriesData> GetListTimelineByMachineID(int machineID, DateTime startDate, DateTime endDate);

        /// <summary>
        /// Dữ liệu biểu đồ % thời gian máy chạy - theo máy cụ thể
        /// </summary>
        /// <param name="machineID"></param>
        /// <returns></returns>
        List<Common.Data_MachineStatus> GetListStatusPercentByMachineID(int machineID, DateTime startDate, DateTime endDate);

    }
}
