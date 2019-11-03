using Microsoft.EntityFrameworkCore;

namespace teamSegurosApi.Data
{
    public class SgContext : DbContext
    {
        //public DbSet<> Computer { get; set; }
        public SgContext(DbContextOptions<SgContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
    }
}
