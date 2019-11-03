using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace teamSegurosApi.Migrations
{
    public partial class UpdateModelAfterDeleteTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Modelos_ModeloId",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_ModeloId",
                table: "Vehiculos");

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("788555c6-6e10-4ab5-b04d-1de633c9b6ee"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("89db24be-e235-43b6-af06-4d058490380e"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("ea1832ce-d9bc-454b-8a47-856420903590"));

            migrationBuilder.DeleteData(
                table: "Modelos",
                keyColumn: "Id",
                keyValue: new Guid("12e3ff4f-5380-4610-a25f-fcb506edd02e"));

            migrationBuilder.DeleteData(
                table: "Modelos",
                keyColumn: "Id",
                keyValue: new Guid("7fc3b244-5ce0-4398-a6b7-2776148cd3a4"));

            migrationBuilder.DeleteData(
                table: "Modelos",
                keyColumn: "Id",
                keyValue: new Guid("ec583b81-fb75-48fd-952c-cd5378053b06"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dab5f3a9-facf-4798-886e-97a6824c0361"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f067e95d-b9bf-4122-9ef9-86e558177cfa"));

            migrationBuilder.DeleteData(
                table: "TipoDocumentos",
                keyColumn: "Id",
                keyValue: new Guid("14c9eebb-f1a4-490e-97b6-e3a50c7d4482"));

            migrationBuilder.DeleteData(
                table: "TipoDocumentos",
                keyColumn: "Id",
                keyValue: new Guid("4a6ced24-1af6-4e29-bcb2-0f68491d4cca"));

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "Id",
                keyValue: new Guid("24f3a5fe-85f9-4d93-af4a-4e485e13c348"));

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "Id",
                keyValue: new Guid("5f97f857-ee87-4d06-915d-048236613a7f"));

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "Id",
                keyValue: new Guid("f3bbcfa6-c904-405a-9d0f-2fd5f9541bd8"));

            migrationBuilder.InsertData(
                table: "Ciudades",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("5c52fac1-b22e-4eb5-9b37-822220429be3"), "Bogota" },
                    { new Guid("432f31aa-d327-42b8-9f3c-25a245720b2c"), "Medellin" },
                    { new Guid("af5cb727-b75e-4011-a037-3d68f83d54d7"), "Cali" }
                });

            migrationBuilder.InsertData(
                table: "Marcas",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("46809d9e-c5b1-441f-8c70-b0c084ee9cd9"), "Mazda" },
                    { new Guid("17ee1507-6bef-49ad-ac68-cb607ee75f12"), "Renault" },
                    { new Guid("a6d14c27-8645-4a53-b316-16217320cab5"), "Nissan" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("54baf4b0-9e98-4c3a-90e2-d3c38111cc92"), "Administrador" },
                    { new Guid("c6c44bfb-7d75-4ae5-a9da-23e91330fd10"), "Usuario" }
                });

            migrationBuilder.InsertData(
                table: "TipoDocumentos",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("fbf4bdc4-a7b5-4810-8388-f06a9dfc766b"), "Cedula de ciudadania" },
                    { new Guid("04e2375a-59ee-479b-ae61-c46889aab7fe"), "Tarjeta de identidad" }
                });

            migrationBuilder.InsertData(
                table: "Modelos",
                columns: new[] { "Id", "MarcaId", "Nombre" },
                values: new object[] { new Guid("74a81ad4-0166-48e6-a673-85fd68b3d5a2"), new Guid("46809d9e-c5b1-441f-8c70-b0c084ee9cd9"), "Mazda3" });

            migrationBuilder.InsertData(
                table: "Modelos",
                columns: new[] { "Id", "MarcaId", "Nombre" },
                values: new object[] { new Guid("573e36ca-f3e3-4b66-993c-d8b28135326b"), new Guid("17ee1507-6bef-49ad-ac68-cb607ee75f12"), "Symbol" });

            migrationBuilder.InsertData(
                table: "Modelos",
                columns: new[] { "Id", "MarcaId", "Nombre" },
                values: new object[] { new Guid("5a5cba5c-b8ea-498e-9e4a-3349fd7d07b1"), new Guid("a6d14c27-8645-4a53-b316-16217320cab5"), "Versa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("432f31aa-d327-42b8-9f3c-25a245720b2c"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("5c52fac1-b22e-4eb5-9b37-822220429be3"));

            migrationBuilder.DeleteData(
                table: "Ciudades",
                keyColumn: "Id",
                keyValue: new Guid("af5cb727-b75e-4011-a037-3d68f83d54d7"));

            migrationBuilder.DeleteData(
                table: "Modelos",
                keyColumn: "Id",
                keyValue: new Guid("573e36ca-f3e3-4b66-993c-d8b28135326b"));

            migrationBuilder.DeleteData(
                table: "Modelos",
                keyColumn: "Id",
                keyValue: new Guid("5a5cba5c-b8ea-498e-9e4a-3349fd7d07b1"));

            migrationBuilder.DeleteData(
                table: "Modelos",
                keyColumn: "Id",
                keyValue: new Guid("74a81ad4-0166-48e6-a673-85fd68b3d5a2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54baf4b0-9e98-4c3a-90e2-d3c38111cc92"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c6c44bfb-7d75-4ae5-a9da-23e91330fd10"));

            migrationBuilder.DeleteData(
                table: "TipoDocumentos",
                keyColumn: "Id",
                keyValue: new Guid("04e2375a-59ee-479b-ae61-c46889aab7fe"));

            migrationBuilder.DeleteData(
                table: "TipoDocumentos",
                keyColumn: "Id",
                keyValue: new Guid("fbf4bdc4-a7b5-4810-8388-f06a9dfc766b"));

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "Id",
                keyValue: new Guid("17ee1507-6bef-49ad-ac68-cb607ee75f12"));

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "Id",
                keyValue: new Guid("46809d9e-c5b1-441f-8c70-b0c084ee9cd9"));

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "Id",
                keyValue: new Guid("a6d14c27-8645-4a53-b316-16217320cab5"));

            migrationBuilder.InsertData(
                table: "Ciudades",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("89db24be-e235-43b6-af06-4d058490380e"), "Bogota" },
                    { new Guid("788555c6-6e10-4ab5-b04d-1de633c9b6ee"), "Medellin" },
                    { new Guid("ea1832ce-d9bc-454b-8a47-856420903590"), "Cali" }
                });

            migrationBuilder.InsertData(
                table: "Marcas",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("f3bbcfa6-c904-405a-9d0f-2fd5f9541bd8"), "Mazda" },
                    { new Guid("24f3a5fe-85f9-4d93-af4a-4e485e13c348"), "Renault" },
                    { new Guid("5f97f857-ee87-4d06-915d-048236613a7f"), "Nissan" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("dab5f3a9-facf-4798-886e-97a6824c0361"), "Administrador" },
                    { new Guid("f067e95d-b9bf-4122-9ef9-86e558177cfa"), "Usuario" }
                });

            migrationBuilder.InsertData(
                table: "TipoDocumentos",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("14c9eebb-f1a4-490e-97b6-e3a50c7d4482"), "Cedula de ciudadania" },
                    { new Guid("4a6ced24-1af6-4e29-bcb2-0f68491d4cca"), "Tarjeta de identidad" }
                });

            migrationBuilder.InsertData(
                table: "Modelos",
                columns: new[] { "Id", "MarcaId", "Nombre" },
                values: new object[] { new Guid("12e3ff4f-5380-4610-a25f-fcb506edd02e"), new Guid("f3bbcfa6-c904-405a-9d0f-2fd5f9541bd8"), "Mazda3" });

            migrationBuilder.InsertData(
                table: "Modelos",
                columns: new[] { "Id", "MarcaId", "Nombre" },
                values: new object[] { new Guid("ec583b81-fb75-48fd-952c-cd5378053b06"), new Guid("24f3a5fe-85f9-4d93-af4a-4e485e13c348"), "Symbol" });

            migrationBuilder.InsertData(
                table: "Modelos",
                columns: new[] { "Id", "MarcaId", "Nombre" },
                values: new object[] { new Guid("7fc3b244-5ce0-4398-a6b7-2776148cd3a4"), new Guid("5f97f857-ee87-4d06-915d-048236613a7f"), "Versa" });

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_ModeloId",
                table: "Vehiculos",
                column: "ModeloId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Modelos_ModeloId",
                table: "Vehiculos",
                column: "ModeloId",
                principalTable: "Modelos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
