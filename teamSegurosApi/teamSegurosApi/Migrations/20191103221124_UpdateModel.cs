using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace teamSegurosApi.Migrations
{
    public partial class UpdateModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modeloss_Marcas_MarcaId",
                table: "Modeloss");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Modeloss_ModeloId",
                table: "Vehiculos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Modeloss",
                table: "Modeloss");

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

            migrationBuilder.RenameTable(
                name: "Modeloss",
                newName: "Modelos");

            migrationBuilder.RenameIndex(
                name: "IX_Modeloss_MarcaId",
                table: "Modelos",
                newName: "IX_Modelos_MarcaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Modelos",
                table: "Modelos",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Modelos_Marcas_MarcaId",
                table: "Modelos",
                column: "MarcaId",
                principalTable: "Marcas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Modelos_ModeloId",
                table: "Vehiculos",
                column: "ModeloId",
                principalTable: "Modelos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modelos_Marcas_MarcaId",
                table: "Modelos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Modelos_ModeloId",
                table: "Vehiculos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Modelos",
                table: "Modelos");

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

            migrationBuilder.RenameTable(
                name: "Modelos",
                newName: "Modeloss");

            migrationBuilder.RenameIndex(
                name: "IX_Modelos_MarcaId",
                table: "Modeloss",
                newName: "IX_Modeloss_MarcaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Modeloss",
                table: "Modeloss",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Modeloss_Marcas_MarcaId",
                table: "Modeloss",
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
    }
}
