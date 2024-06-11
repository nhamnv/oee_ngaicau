using Common.ViewModels;

namespace Service.IService
{
    public interface IDashboardService
    {
        /// <summary>
        /// Lấy dữ liệu màn hình Dashboard tổng quan
        /// </summary>
        /// <param name="repotDate"></param>
        /// <returns></returns>
        DashboardViewModel GetData(DateTime repotDate);

        /// <summary>
        /// Lấy dữ liệu mành hình dashboard chi tiết máy theo trạng thái và nhóm máy
        /// </summary>
        /// <param name="MachineStatusID"></param>
        /// <param name="MachineGroupID"></param>
        /// <returns></returns>
        MachineByStatusGroupDetailViewModel GetMachineByStatusGroupDetail(string MachineStatusID, string MachineGroupID, DateTime repotDate);
    }
}
