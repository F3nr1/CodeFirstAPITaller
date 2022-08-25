using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBTallerM.Migrations
{
    public partial class IntDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administrativo",
                columns: table => new
                {
                    AdmID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NivelEstudio = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PersonaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrativo", x => x.AdmID);
                });

            migrationBuilder.CreateTable(
                name: "Direccion",
                columns: table => new
                {
                    DireccionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Zona = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TipoCalle = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Num1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Num2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Num3 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direccion", x => x.DireccionID);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    PersonaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Apellido = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Telefono = table.Column<int>(type: "int", nullable: true),
                    DireccionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.PersonaID);
                    table.ForeignKey(
                        name: "FK_Direccion_Persona",
                        column: x => x.DireccionID,
                        principalTable: "Direccion",
                        principalColumn: "DireccionID");
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Correo = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    PersonaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteID);
                    table.ForeignKey(
                        name: "FK_Cliente_Persona",
                        column: x => x.PersonaID,
                        principalTable: "Persona",
                        principalColumn: "PersonaID");
                });

            migrationBuilder.CreateTable(
                name: "Mecanico",
                columns: table => new
                {
                    MecanicoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NivelEstudios = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PersonaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mecanico", x => x.MecanicoID);
                    table.ForeignKey(
                        name: "FK_Mecanico_Persona",
                        column: x => x.PersonaID,
                        principalTable: "Persona",
                        principalColumn: "PersonaID");
                });

            migrationBuilder.CreateTable(
                name: "Vehiculo",
                columns: table => new
                {
                    VehiculoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Placa = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    TipoVehiculo = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Marca = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    CapacidadPasajeros = table.Column<int>(type: "int", nullable: true),
                    Cilindrada = table.Column<int>(type: "int", nullable: true),
                    ClienteID = table.Column<int>(type: "int", nullable: false),
                    MecanicoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculo", x => x.VehiculoID);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Cliente",
                        column: x => x.ClienteID,
                        principalTable: "Cliente",
                        principalColumn: "ClienteID");
                    table.ForeignKey(
                        name: "FK_Vehiculo_Mecanico",
                        column: x => x.MecanicoID,
                        principalTable: "Mecanico",
                        principalColumn: "MecanicoID");
                });

            migrationBuilder.CreateTable(
                name: "Diagnostico",
                columns: table => new
                {
                    DiagID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoRevision = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RevisionNiveles = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TipoRepuesto = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Repuesto = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    VehiculoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnostico", x => x.DiagID);
                    table.ForeignKey(
                        name: "FK_Diagnostico_Vehiculo",
                        column: x => x.VehiculoID,
                        principalTable: "Vehiculo",
                        principalColumn: "VehiculoID");
                });

            migrationBuilder.CreateTable(
                name: "Soat",
                columns: table => new
                {
                    SoatID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaVencimiento = table.Column<DateTime>(type: "date", nullable: true),
                    PuedeTransitar = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    VehiculoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Soat", x => x.SoatID);
                    table.ForeignKey(
                        name: "FK_Soat_Vehiculo",
                        column: x => x.VehiculoID,
                        principalTable: "Vehiculo",
                        principalColumn: "VehiculoID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_PersonaID",
                table: "Cliente",
                column: "PersonaID");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnostico_VehiculoID",
                table: "Diagnostico",
                column: "VehiculoID");

            migrationBuilder.CreateIndex(
                name: "IX_Mecanico_PersonaID",
                table: "Mecanico",
                column: "PersonaID");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_DireccionID",
                table: "Persona",
                column: "DireccionID");

            migrationBuilder.CreateIndex(
                name: "IX_Soat_VehiculoID",
                table: "Soat",
                column: "VehiculoID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_ClienteID",
                table: "Vehiculo",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_MecanicoID",
                table: "Vehiculo",
                column: "MecanicoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administrativo");

            migrationBuilder.DropTable(
                name: "Diagnostico");

            migrationBuilder.DropTable(
                name: "Soat");

            migrationBuilder.DropTable(
                name: "Vehiculo");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Mecanico");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Direccion");
        }
    }
}
