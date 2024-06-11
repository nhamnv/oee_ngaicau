using Repository.Entity;

namespace Service.IService
{
    public interface IData_MenuService
    {
        ICollection<Data_Menu> GetList();
    }
}
