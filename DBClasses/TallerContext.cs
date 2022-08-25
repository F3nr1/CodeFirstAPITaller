
using DBTallerM.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace DBTallerM { 

public class TallerContext : DbContext
{
    public TallerContext(DbContextOptions<TallerContext> options)
        : base(options)

    {

    }


        public  DbSet<Administrativo> Administrativos { get; set; } = null!;
        public  DbSet<Cliente> Clientes { get; set; } = null!;
        public  DbSet<Diagnostico> Diagnosticos { get; set; } = null!;
        public  DbSet<Direccion> Direccions { get; set; } = null!;
        public  DbSet<Mecanico> Mecanicos { get; set; } = null!;
        public  DbSet<Persona> Personas { get; set; } = null!;
        public  DbSet<Soat> Soats { get; set; } = null!;
        public  DbSet<Vehiculo> Vehiculos { get; set; } = null!;




        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

  

            modelBuilder.Entity<Administrativo>(entity =>
            {
                entity.HasKey(e => e.AdmId);

                entity.ToTable("Administrativo");

                entity.Property(e => e.AdmId).HasColumnName("AdmID");

                entity.Property(e => e.NivelEstudio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PersonaId).HasColumnName("PersonaID");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("Cliente");

                entity.Property(e => e.ClienteId).HasColumnName("ClienteID");

                entity.Property(e => e.Correo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PersonaId).HasColumnName("PersonaID");

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.PersonaId)
                    .HasConstraintName("FK_Cliente_Persona");
            });

            modelBuilder.Entity<Diagnostico>(entity =>
            {
                entity.HasKey(e => e.DiagId);

                entity.ToTable("Diagnostico");

                entity.Property(e => e.DiagId).HasColumnName("DiagID");

                entity.Property(e => e.Repuesto)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RevisionNiveles)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoRepuesto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoRevision)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehiculoId).HasColumnName("VehiculoID");

                entity.HasOne(d => d.Vehiculo)
                    .WithMany(p => p.Diagnosticos)
                    .HasForeignKey(d => d.VehiculoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Diagnostico_Vehiculo");
            });

            modelBuilder.Entity<Direccion>(entity =>
            {
                entity.ToTable("Direccion");

                entity.Property(e => e.DireccionId).HasColumnName("DireccionID");

                entity.Property(e => e.Num1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Num2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Num3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCalle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zona)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Mecanico>(entity =>
            {
                entity.ToTable("Mecanico");

                entity.Property(e => e.MecanicoId).HasColumnName("MecanicoID");

                entity.Property(e => e.NivelEstudios)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PersonaId).HasColumnName("PersonaID");

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.Mecanicos)
                    .HasForeignKey(d => d.PersonaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mecanico_Persona");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.ToTable("Persona");

                entity.Property(e => e.PersonaId).HasColumnName("PersonaID");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionId).HasColumnName("DireccionID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Direccion)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.DireccionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Direccion_Persona");
            });

            modelBuilder.Entity<Soat>(entity =>
            {
                entity.ToTable("Soat");

                entity.Property(e => e.SoatId).HasColumnName("SoatID");

                entity.Property(e => e.FechaVencimiento).HasColumnType("date");

                entity.Property(e => e.PuedeTransitar)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehiculoId).HasColumnName("VehiculoID");

                entity.HasOne(d => d.Vehiculo)
                    .WithMany(p => p.Soats)
                    .HasForeignKey(d => d.VehiculoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Soat_Vehiculo");
            });

            modelBuilder.Entity<Vehiculo>(entity =>
            {
                entity.ToTable("Vehiculo");

                entity.Property(e => e.VehiculoId).HasColumnName("VehiculoID");

                entity.Property(e => e.ClienteId).HasColumnName("ClienteID");

                entity.Property(e => e.Marca)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MecanicoId).HasColumnName("MecanicoID");

                entity.Property(e => e.Placa)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TipoVehiculo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Vehiculos)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vehiculo_Cliente");

                entity.HasOne(d => d.Mecanico)
                    .WithMany(p => p.Vehiculos)
                    .HasForeignKey(d => d.MecanicoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vehiculo_Mecanico");
            });







        }



}
}