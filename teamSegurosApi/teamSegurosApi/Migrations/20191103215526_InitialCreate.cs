using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace teamSegurosApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ciudades",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoDocumentos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocumentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    MarcaId = table.Column<Guid>(nullable: false),
                    ModeloId = table.Column<Guid>(nullable: false),
                    Año = table.Column<int>(nullable: false),
                    Placa = table.Column<string>(maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(maxLength: 50, nullable: false),
                    TipoDocumentoId = table.Column<Guid>(nullable: false),
                    NumeroDocumento = table.Column<int>(maxLength: 50, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    CiudadId = table.Column<Guid>(nullable: false),
                    RolId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Ciudades_CiudadId",
                        column: x => x.CiudadId,
                        principalTable: "Ciudades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuarios_Roles_RolId",
                        column: x => x.RolId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuarios_TipoDocumentos_TipoDocumentoId",
                        column: x => x.TipoDocumentoId,
                        principalTable: "TipoDocumentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    VehiculoId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Marcas_Vehiculos_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "Vehiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Seguros",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UsuarioId = table.Column<Guid>(nullable: false),
                    VehiculoId = table.Column<Guid>(nullable: false),
                    Valor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seguros_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Seguros_Vehiculos_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "Vehiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Modeloss",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    MarcaId = table.Column<Guid>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    VehiculoId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modeloss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modeloss_Marcas_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marcas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Modeloss_Vehiculos_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "Vehiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Ciudades",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("60e168bf-b3fe-414f-b37a-294db75cdb94"), "Bogota" },
                    { new Guid("cbf14e62-5e96-4597-9d25-6ee222872fb3"), "Medellin" },
                    { new Guid("bb21e244-b2d4-40d9-a5a1-facf93ff43cd"), "Cali" }
                });

            migrationBuilder.InsertData(
                table: "Marcas",
                columns: new[] { "Id", "Nombre", "VehiculoId" },
                values: new object[,]
                {
                    { new Guid("12080c6c-b388-4f2c-ba5d-182aa8a69dbd"), "Mazda", null },
                    { new Guid("7aea73ff-00ea-43b1-8578-8f589bddf643"), "Renault", null },
                    { new Guid("c4f8d288-714a-4729-a9a4-6fdbd549ccd2"), "Nissan", null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("d1f43590-adc3-4812-95bd-3035e4b5e4fd"), "Administrador" },
                    { new Guid("9da8beda-e526-4e47-a801-9735d1bfeb57"), "Usuario" }
                });

            migrationBuilder.InsertData(
                table: "TipoDocumentos",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("d095f315-bc3f-4204-bcfc-4c5c644fbc30"), "Cedula de ciudadania" },
                    { new Guid("3cf031a9-8991-40c2-b1d4-998369de3b23"), "Tarjeta de identidad" }
                });

            migrationBuilder.InsertData(
                table: "Modeloss",
                columns: new[] { "Id", "MarcaId", "Nombre", "VehiculoId" },
                values: new object[] { new Guid("eab4b435-750c-47be-8784-f075533d3a73"), new Guid("12080c6c-b388-4f2c-ba5d-182aa8a69dbd"), "Mazda3", null });

            migrationBuilder.InsertData(
                table: "Modeloss",
                columns: new[] { "Id", "MarcaId", "Nombre", "VehiculoId" },
                values: new object[] { new Guid("d738a7d8-72e7-43cb-ac6f-6943cd7f91f2"), new Guid("7aea73ff-00ea-43b1-8578-8f589bddf643"), "Symbol", null });

            migrationBuilder.InsertData(
                table: "Modeloss",
                columns: new[] { "Id", "MarcaId", "Nombre", "VehiculoId" },
                values: new object[] { new Guid("662b509c-c60b-4462-9dd6-5ee2261e456a"), new Guid("c4f8d288-714a-4729-a9a4-6fdbd549ccd2"), "Versa", null });

            migrationBuilder.CreateIndex(
                name: "IX_Marcas_VehiculoId",
                table: "Marcas",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Modeloss_MarcaId",
                table: "Modeloss",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Modeloss_VehiculoId",
                table: "Modeloss",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Seguros_UsuarioId",
                table: "Seguros",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Seguros_VehiculoId",
                table: "Seguros",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_CiudadId",
                table: "Usuarios",
                column: "CiudadId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_RolId",
                table: "Usuarios",
                column: "RolId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_TipoDocumentoId",
                table: "Usuarios",
                column: "TipoDocumentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Modeloss");

            migrationBuilder.DropTable(
                name: "Seguros");

            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "Ciudades");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "TipoDocumentos");
        }
    }
}
