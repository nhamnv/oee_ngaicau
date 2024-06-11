using Microsoft.EntityFrameworkCore;
using Repository.Entity;

namespace Repository
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions option) : base(option)
        {

        }

        public DbSet<Data_Menu> Data_Menus { get; set; }
        public DbSet<Data_Error> Data_Errors { get; set; }
    }
}
