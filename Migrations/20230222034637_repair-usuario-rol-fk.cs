using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestructure.API.Migrations
{
    /// <inheritdoc />
    public partial class repairusuariorolfk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Rol_rolid",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_rolid",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "rolid",
                table: "Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_fkRol",
                table: "Usuario",
                column: "fkRol");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Rol_fkRol",
                table: "Usuario",
                column: "fkRol",
                principalTable: "Rol",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Rol_fkRol",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_fkRol",
                table: "Usuario");

            migrationBuilder.AddColumn<int>(
                name: "rolid",
                table: "Usuario",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_rolid",
                table: "Usuario",
                column: "rolid");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Rol_rolid",
                table: "Usuario",
                column: "rolid",
                principalTable: "Rol",
                principalColumn: "id");
        }
    }
}
