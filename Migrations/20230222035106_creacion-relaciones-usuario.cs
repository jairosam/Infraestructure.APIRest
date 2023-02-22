using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestructure.API.Migrations
{
    /// <inheritdoc />
    public partial class creacionrelacionesusuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "fkUsuario",
                table: "Inversor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "fkUsuario",
                table: "Emprendimiento",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Inversor_fkUsuario",
                table: "Inversor",
                column: "fkUsuario",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Emprendimiento_fkUsuario",
                table: "Emprendimiento",
                column: "fkUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Emprendimiento_Usuario_fkUsuario",
                table: "Emprendimiento",
                column: "fkUsuario",
                principalTable: "Usuario",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inversor_Usuario_fkUsuario",
                table: "Inversor",
                column: "fkUsuario",
                principalTable: "Usuario",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emprendimiento_Usuario_fkUsuario",
                table: "Emprendimiento");

            migrationBuilder.DropForeignKey(
                name: "FK_Inversor_Usuario_fkUsuario",
                table: "Inversor");

            migrationBuilder.DropIndex(
                name: "IX_Inversor_fkUsuario",
                table: "Inversor");

            migrationBuilder.DropIndex(
                name: "IX_Emprendimiento_fkUsuario",
                table: "Emprendimiento");

            migrationBuilder.DropColumn(
                name: "fkUsuario",
                table: "Inversor");

            migrationBuilder.DropColumn(
                name: "fkUsuario",
                table: "Emprendimiento");
        }
    }
}
