using Newtonsoft.Json;
using Repository.Entity;
using Repository.IRepository;

namespace Repository.Repository
{
    public class Data_ErrorRepository : GenericRepository<Data_Error>, IData_ErrorRepository
    {
        private readonly AppDBContext _dbContext;
        public Data_ErrorRepository(AppDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Data_Error> GetCommonList()
        {
            List<Data_Error> reval = new List<Data_Error>();
            try
            {
                string jStr = JsonConvert.SerializeObject(Common.StaticData.Data_Error);
                reval = JsonConvert.DeserializeObject<List<Data_Error>>(jStr) ?? new List<Data_Error>();
            }
            catch (Exception)
            {

            }
            return reval;
        }
    }
}
