// <auto-generated />
using DBTallerM;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DBTallerM.Migrations
{
    [DbContext(typeof(TallerContext))]
    partial class TallerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DBTallerM.Models.Administrativo", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminID"), 1L, 1);

                    b.Property<string>("NivelEstudio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonaID")
                        .HasColumnType("int");

                    b.HasKey("AdminID");

                    b.HasIndex("PersonaID");

                    b.ToTable("Administrativo", (string)null);
                });

            modelBuilder.Entity("DBTallerM.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteID"), 1L, 1);

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonaID")
                        .HasColumnType("int");

                    b.HasKey("ClienteID");

                    b.HasIndex("PersonaID");

                    b.ToTable("Cliente", (string)null);
                });

            modelBuilder.Entity("DBTallerM.Models.Direccion", b =>
                {
                    b.Property<int>("DireccionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DireccionID"), 1L, 1);

                    b.Property<string>("Num1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Num2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Num3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoCalle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DireccionID");

                    b.ToTable("Direccion", (string)null);
                });

            modelBuilder.Entity("DBTallerM.Models.Mecanico", b =>
                {
                    b.Property<int>("MecanicoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MecanicoID"), 1L, 1);

                    b.Property<string>("NivelEstudio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonaID")
                        .HasColumnType("int");

                    b.HasKey("MecanicoID");

                    b.HasIndex("PersonaID");

                    b.ToTable("Mecanico", (string)null);
                });

            modelBuilder.Entity("DBTallerM.Models.Persona", b =>
                {
                    b.Property<int>("PersonaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonaID"), 1L, 1);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DireccionID")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("PersonaID");

                    b.HasIndex("DireccionID");

                    b.ToTable("Persona", (string)null);
                });

            modelBuilder.Entity("DBTallerM.Models.Administrativo", b =>
                {
                    b.HasOne("DBTallerM.Models.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("DBTallerM.Models.Cliente", b =>
                {
                    b.HasOne("DBTallerM.Models.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("DBTallerM.Models.Mecanico", b =>
                {
                    b.HasOne("DBTallerM.Models.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("DBTallerM.Models.Persona", b =>
                {
                    b.HasOne("DBTallerM.Models.Direccion", "Direccion")
                        .WithMany()
                        .HasForeignKey("DireccionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Direccion");
                });
#pragma warning restore 612, 618
        }
    }
}
