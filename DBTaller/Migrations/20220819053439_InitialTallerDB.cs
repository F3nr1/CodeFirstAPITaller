using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBTaller.Migrations
{
    public partial class InitialTallerDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Direccion",
                columns: table => new
                {
                    DireccionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Zona = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TipoCalle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Num1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Num2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Num3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
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
                    Nombre = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Telefono = table.Column<int>(type: "int", maxLength: 25, nullable: false),
                    DireccionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.PersonaID);
                    table.ForeignKey(
                        name: "FK_Persona_Direccion_DireccionID",
                        column: x => x.DireccionID,
                        principalTable: "Direccion",
                        principalColumn: "DireccionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Administrativo",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NivelEstudio = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PersonaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrativo", x => x.AdminID);
                    table.ForeignKey(
                        name: "FK_Administrativo_Persona_PersonaID",
                        column: x => x.PersonaID,
                        principalTable: "Persona",
                        principalColumn: "PersonaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Correo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PersonaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteID);
                    table.ForeignKey(
                        name: "FK_Cliente_Persona_PersonaID",
                        column: x => x.PersonaID,
                        principalTable: "Persona",
                        principalColumn: "PersonaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mecanico",
                columns: table => new
                {
                    MecanicoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NivelEstudio = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PersonaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mecanico", x => x.MecanicoID);
                    table.ForeignKey(
                        name: "FK_Mecanico_Persona_PersonaID",
                        column: x => x.PersonaID,
                        principalTable: "Persona",
                        principalColumn: "PersonaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    VehiculoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Placa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TipoVehiculo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CapacidadPasajeros = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cilindrada = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ClienteID = table.Column<int>(type: "int", nullable: false),
                    MecanicoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.VehiculoID);
                    table.ForeignKey(
                        name: "FK_Vehiculos_Cliente_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Cliente",
                        principalColumn: "ClienteID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehiculos_Mecanico_MecanicoID",
                        column: x => x.MecanicoID,
                        principalTable: "Mecanico",
                        principalColumn: "MecanicoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Diagnostico",
                columns: table => new
                {
                    DiagID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoRevision = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RevisionNiveles = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TipoRepuestos = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Repuesto = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    VehiculoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnostico", x => x.DiagID);
                    table.ForeignKey(
                        name: "FK_Diagnostico_Vehiculos_VehiculoID",
                        column: x => x.VehiculoID,
                        principalTable: "Vehiculos",
                        principalColumn: "VehiculoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Soat",
                columns: table => new
                {
                    SoatID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaVencimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PuedeTransitar = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    VehiculoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Soat", x => x.SoatID);
                    table.ForeignKey(
                        name: "FK_Soat_Vehiculos_VehiculoID",
                        column: x => x.VehiculoID,
                        principalTable: "Vehiculos",
                        principalColumn: "VehiculoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Administrativo_PersonaID",
                table: "Administrativo",
                column: "PersonaID");

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
                name: "IX_Vehiculos_ClienteID",
                table: "Vehiculos",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_MecanicoID",
                table: "Vehiculos",
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
                name: "Vehiculos");

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
