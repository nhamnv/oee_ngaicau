using Repository.Entity;

namespace Repository.IRepository
{
    public interface IData_MenuRepository : IGenericRepository<Data_Menu>
    {
        List<Data_Menu> GetList();
    }
}
