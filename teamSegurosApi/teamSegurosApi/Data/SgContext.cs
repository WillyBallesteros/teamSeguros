using Microsoft.EntityFrameworkCore;
using System.Linq;
using teamSegurosApi.Models;

namespace teamSegurosApi.Data
{
    public class SgContext : DbContext
    {
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Marca> Marcas { get; set; }

        public DbSet<Modelo> Modeloss { get; set; }

        public DbSet<Rol> Roles { get; set; }

        public DbSet<Seguro> Seguros { get; set; }

        public DbSet<TipoDocumento> TipoDocumentos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Vehiculo> Vehiculos { get; set; }

        public SgContext(DbContextOptions<SgContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            var seedData = new SeedData();
            modelBuilder.Entity<Ciudad>().HasData(seedData.GetCiudades().ToArray());
            modelBuilder.Entity<Rol>().HasData(seedData.GetRol().ToArray());
            modelBuilder.Entity<TipoDocumento>().HasData(seedData.GetTipoDocumento().ToArray());
            modelBuilder.Entity<Marca>().HasData(seedData.GetMarcas().ToArray());
            modelBuilder.Entity<Modelo>().HasData(seedData.GetModelo().ToArray());





        }
    }
}
