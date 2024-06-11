using Repository.IRepository;
using Service.IService;

namespace Service.Service
{
    public class Data_ErrorService : IData_ErrorService
    {
        private readonly IData_ErrorRepository _data_ErrorRepository;

        public Data_ErrorService(IData_ErrorRepository data_ErrorRepository)
        {
            _data_ErrorRepository = data_ErrorRepository;
        }

        public List<Repository.Entity.Data_Error> GetCommonList()
        {
            return _data_ErrorRepository.GetCommonList();
        }
    }
}
