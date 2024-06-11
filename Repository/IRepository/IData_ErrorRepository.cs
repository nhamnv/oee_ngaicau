using Repository.Entity;

namespace Repository.IRepository
{
    public interface IData_ErrorRepository : IGenericRepository<Data_Error>
    {
        List<Data_Error> GetCommonList();
    }
}
