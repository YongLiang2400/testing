using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AceJobAgency.Model
{
    public class MyDbContext:IdentityDbContext<ApplicationUser>
    {

        private readonly IConfiguration _configuration;
        //public MyDbContext(DbContextOptions<MyDbContext> options):base(options){ }

        public MyDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = _configuration.GetConnectionString("MyConnection"); optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
