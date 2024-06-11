namespace Service.IService
{
    public interface IErrorMachineService
    {
        IEnumerable<dynamic> GetErrorList(string TimeRangeID, string MachineGroupID, string MachineLocationID);
        dynamic GetTop10ErrorList(string TimeRangeID, string MachineGroupID, string MachineLocationID);

        IEnumerable<dynamic> GetErrorListByMachineID(int machineID);
    }
}
