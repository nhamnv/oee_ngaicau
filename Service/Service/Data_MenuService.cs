using Repository.Entity;
using Repository.IRepository;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
	public class Data_MenuService: IData_MenuService
	{
		private readonly IData_MenuRepository _data_MenuRepository;

        public Data_MenuService(IData_MenuRepository data_MenuRepository)
        {
			_data_MenuRepository = data_MenuRepository;
		}

        public ICollection<Data_Menu> GetList()
        {
            return _data_MenuRepository.GetList();
        }
    }
}
