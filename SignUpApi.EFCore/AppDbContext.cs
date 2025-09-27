using Microsoft.EntityFrameworkCore;
using SignUpApi.Model;

namespace SignUpApi.EFCore
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }




        public DbSet<Operator> Operators { get; set; }
    }

}
