using Microsoft.EntityFrameworkCore;
using DBTaller.models;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;

namespace DBTaller
{


    public class TallerContext : DbContext
    {
        public TallerContext(DbContextOptions<TallerContext> options)
            : base(options)
        {


        }

        public DbSet<Direccion> Direccions { get; set; }
        public DbSet<Persona> Personas { get; set; }

        public DbSet<Cliente> Clientes { get; set; }
        
        public DbSet<Mecanico> Mecanicos { get; set; }

        public DbSet<Administrativo> Administrativos { get; set; }

        public DbSet<Vehiculo> Vehiculos {get; set; }    
        public DbSet<Soat> Soats { get; set; }
        public DbSet<Diagnostico> Diagnosticos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Direccion>().ToTable("Direccion");
            modelBuilder.Entity<Persona>().ToTable("Persona");
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Mecanico>().ToTable("Mecanico");
            modelBuilder.Entity<Administrativo>().ToTable("Administrativo");
            modelBuilder.Entity<Vehiculo>().ToTable("Vehiculos");
            modelBuilder.Entity<Soat>().ToTable("Soat");
            modelBuilder.Entity<Diagnostico>().ToTable("Diagnostico");
        }


    }
}