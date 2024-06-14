using Common;
using Common.ViewModels;

namespace Service.IService
{
    public interface IMachineManagementService
    {
        /// <summary>
        /// Thống kê máy
        /// </summary>
        /// <returns></returns>
        MachineStatiticsViewModel GetStatitics();

        /// <summary>
        /// Chi tiết máy
        /// </summary>
        /// <param name="machineID"></param>
        /// <param name="machineLocationID"></param>
        /// <returns></returns>
        MachineDetailViewModel GetDetails(int machineID, int machineLocationID);

        /// <summary>
        /// Lịch sử sửa chữa máy
        /// </summary>
        /// <param name="machineID"></param>
        /// <returns></returns>
        List<Data_RepaireHistory> GetMachineRepaireHistory(int machineID);

        /// <summary>
        /// Checklist bảo dưỡng máy
        /// </summary>
        /// <param name="machineID"></param>
        /// <returns></returns>
        List<Data_MachineMaintenanceList> GetMachineMaintenanceList(int machineID);

        /// <summary>
        /// Danh sách máy với trạng thái hiện tại.
        /// </summary>
        /// <returns></returns>
        List<dynamic> GetMachineStatusList();

        /// <summary>
        /// Danh sách máy
        /// </summary>
        /// <returns></returns>
        List<dynamic> GetListMachine();
    }
}
