using Microsoft.EntityFrameworkCore;

namespace BackShopCore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connetionString = "";
            optionsBuilder.UseSqlServer(connectionString: connetionString);
        }
    }
}