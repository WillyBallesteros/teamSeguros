using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace teamSegurosApi.Migrations
{
    public partial class FixModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Marcas_Vehiculos_VehiculoId",
                table: "Marcas");

            migrationBuilder.DropForeignKey(
                name: "FK_Modeloss_Vehiculos_VehiculoId",
                table: "Modeloss");

            migrationBuilder.DropIndex(
                name: "IX_Modeloss_VehiculoId",
                table: "Modeloss");

            migrationBuilder.DropIndex(
                name: "IX_Marcas_VehiculoId",
                table: "Marcas");

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("60e168bf-b3fe-414f-b37a-294db75cdb94"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("bb21e244-b2d4-40d9-a5a1-facf93ff43cd"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("cbf14e62-5e96-4597-9d25-6ee222872fb3"));

            migrationBuilder.DeleteData(
                table: "Modeloss",
                keyColumn: "Id",
                keyValue: new Guid("662b509c-c60b-4462-9dd6-5ee2261e456a"));

            migrationBuilder.DeleteData(
                table: "Modeloss",
                keyColumn: "Id",
                keyValue: new Guid("d738a7d8-72e7-43cb-ac6f-6943cd7f91f2"));

            migrationBuilder.DeleteData(
                table: "Modeloss",
                keyColumn: "Id",
                keyValue: new Guid("eab4b435-750c-47be-8784-f075533d3a73"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9da8beda-e526-4e47-a801-9735d1bfeb57"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d1f43590-adc3-4812-95bd-3035e4b5e4fd"));

            migrationBuilder.DeleteData(
                table: "TipoDocumentos",
                keyColumn: "Id",
                keyValue: new Guid("3cf031a9-8991-40c2-b1d4-998369de3b23"));

            migrationBuilder.DeleteData(
                table: "TipoDocumentos",
                keyColumn: "Id",
                keyValue: new Guid("d095f315-bc3f-4204-bcfc-4c5c644fbc30"));

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "Id",
                keyValue: new Guid("12080c6c-b388-4f2c-ba5d-182aa8a69dbd"));

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "Id",
                keyValue: new Guid("7aea73ff-00ea-43b1-8578-8f589bddf643"));

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "Id",
                keyValue: new Guid("c4f8d288-714a-4729-a9a4-6fdbd549ccd2"));

            migrationBuilder.DropColumn(
                name: "VehiculoId",
                table: "Modeloss");

            migrationBuilder.DropColumn(
                name: "VehiculoId",
                table: "Marcas");

            migrationBuilder.InsertData(
                table: "Ciudades",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("74b0e01b-0ca4-4054-803d-5dca1f8f7fe7"), "Bogota" },
                    { new Guid("596e351d-b072-4fb5-a9e2-02d5719b5260"), "Medellin" },
                    { new Guid("b895b800-c926-4ac1-92b6-90e1523ed4c0"), "Cali" }
                });

            migrationBuilder.InsertData(
                table: "Marcas",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("abf5b1b5-d34f-448f-8097-ad17696ca343"), "Mazda" },
                    { new Guid("d887a6ec-46a2-4843-b684-108a006287c6"), "Renault" },
                    { new Guid("4d0a1373-2608-4a52-a7bc-9731d73e4d58"), "Nissan" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("74938b5c-52a7-4602-8a6f-9bfa9f694316"), "Administrador" },
                    { new Guid("8e30a13a-9de1-49ce-8788-82a8093c9723"), "Usuario" }
                });

            migrationBuilder.InsertData(
                table: "TipoDocumentos",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("d26c7032-b585-4f07-a455-a51d42f22b99"), "Cedula de ciudadania" },
                    { new Guid("a6be2ac7-1a65-4fb2-af46-90968da31b64"), "Tarjeta de identidad" }
                });

            migrationBuilder.InsertData(
                table: "Modeloss",
                columns: new[] { "Id", "MarcaId", "Nombre" },
                values: new object[] { new Guid("073cef80-00d0-4245-b758-8cfe00d24d23"), new Guid("abf5b1b5-d34f-448f-8097-ad17696ca343"), "Mazda3" });

            migrationBuilder.InsertData(
                table: "Modeloss",
                columns: new[] { "Id", "MarcaId", "Nombre" },
                values: new object[] { new Guid("8d51f976-6139-422c-bfc3-6e07a8290efa"), new Guid("d887a6ec-46a2-4843-b684-108a006287c6"), "Symbol" });

            migrationBuilder.InsertData(
                table: "Modeloss",
                columns: new[] { "Id", "MarcaId", "Nombre" },
                values: new object[] { new Guid("b1c581b9-c752-49b6-b2ea-3fb80478fe52"), new Guid("4d0a1373-2608-4a52-a7bc-9731d73e4d58"), "Versa" });

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_MarcaId",
                table: "Vehiculos",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_ModeloId",
                table: "Vehiculos",
                column: "ModeloId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Marcas_MarcaId",
                table: "Vehiculos",
                column: "MarcaId",
                principalTable: "Marcas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Modeloss_ModeloId",
                table: "Vehiculos",
                column: "ModeloId",
                principalTable: "Modeloss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Marcas_MarcaId",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Modeloss_ModeloId",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_MarcaId",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_ModeloId",
                table: "Vehiculos");

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("596e351d-b072-4fb5-a9e2-02d5719b5260"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("74b0e01b-0ca4-4054-803d-5dca1f8f7fe7"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("b895b800-c926-4ac1-92b6-90e1523ed4c0"));

            migrationBuilder.DeleteData(
                table: "Modeloss",
                keyColumn: "Id",
                keyValue: new Guid("073cef80-00d0-4245-b758-8cfe00d24d23"));

            migrationBuilder.DeleteData(
                table: "Modeloss",
                keyColumn: "Id",
                keyValue: new Guid("8d51f976-6139-422c-bfc3-6e07a8290efa"));

            migrationBuilder.DeleteData(
                table: "Modeloss",
                keyColumn: "Id",
                keyValue: new Guid("b1c581b9-c752-49b6-b2ea-3fb80478fe52"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("74938b5c-52a7-4602-8a6f-9bfa9f694316"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8e30a13a-9de1-49ce-8788-82a8093c9723"));

            migrationBuilder.DeleteData(
                table: "TipoDocumentos",
                keyColumn: "Id",
                keyValue: new Guid("a6be2ac7-1a65-4fb2-af46-90968da31b64"));

            migrationBuilder.DeleteData(
                table: "TipoDocumentos",
                keyColumn: "Id",
                keyValue: new Guid("d26c7032-b585-4f07-a455-a51d42f22b99"));

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "Id",
                keyValue: new Guid("4d0a1373-2608-4a52-a7bc-9731d73e4d58"));

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "Id",
                keyValue: new Guid("abf5b1b5-d34f-448f-8097-ad17696ca343"));

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "Id",
                keyValue: new Guid("d887a6ec-46a2-4843-b684-108a006287c6"));

            migrationBuilder.AddColumn<Guid>(
                name: "VehiculoId",
                table: "Modeloss",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "VehiculoId",
                table: "Marcas",
                type: "uniqueidentifier",
                nullable: true);

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
                name: "IX_Modeloss_VehiculoId",
                table: "Modeloss",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Marcas_VehiculoId",
                table: "Marcas",
                column: "VehiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Marcas_Vehiculos_VehiculoId",
                table: "Marcas",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Modeloss_Vehiculos_VehiculoId",
                table: "Modeloss",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
