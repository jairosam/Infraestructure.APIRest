using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestructure.API.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ciudad",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudad", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Emprendimiento",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    objetivo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emprendimiento", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Inversor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inversor", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rol = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TipoIdentificacion",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoIdentificacion", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TipoOferta",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoOferta = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoOferta", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Colaborador",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    identificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fkEmprendimiento = table.Column<int>(type: "int", nullable: false),
                    emprendimientoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colaborador", x => x.id);
                    table.ForeignKey(
                        name: "FK_Colaborador_Emprendimiento_emprendimientoid",
                        column: x => x.emprendimientoid,
                        principalTable: "Emprendimiento",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Tarjeta",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CCV = table.Column<int>(type: "int", nullable: false),
                    fechaVencimiento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fkInversor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarjeta", x => x.id);
                    table.ForeignKey(
                        name: "FK_Tarjeta_Inversor_fkInversor",
                        column: x => x.fkInversor,
                        principalTable: "Inversor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    correo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    identificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaNacimiento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fkRol = table.Column<int>(type: "int", nullable: false),
                    rolid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.id);
                    table.ForeignKey(
                        name: "FK_Usuario_Rol_rolid",
                        column: x => x.rolid,
                        principalTable: "Rol",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Ofertas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    valor = table.Column<int>(type: "int", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fkEmprendimiento = table.Column<int>(type: "int", nullable: false),
                    emprendimientoid = table.Column<int>(type: "int", nullable: true),
                    fkCiudad = table.Column<int>(type: "int", nullable: false),
                    ciudadid = table.Column<int>(type: "int", nullable: true),
                    fkEstado = table.Column<int>(type: "int", nullable: false),
                    estadoid = table.Column<int>(type: "int", nullable: true),
                    fkTipoOferta = table.Column<int>(type: "int", nullable: false),
                    tipoOfertaid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ofertas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Ofertas_Ciudad_ciudadid",
                        column: x => x.ciudadid,
                        principalTable: "Ciudad",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Ofertas_Emprendimiento_emprendimientoid",
                        column: x => x.emprendimientoid,
                        principalTable: "Emprendimiento",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Ofertas_Estado_estadoid",
                        column: x => x.estadoid,
                        principalTable: "Estado",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Ofertas_TipoOferta_tipoOfertaid",
                        column: x => x.tipoOfertaid,
                        principalTable: "TipoOferta",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Colaborador_emprendimientoid",
                table: "Colaborador",
                column: "emprendimientoid");

            migrationBuilder.CreateIndex(
                name: "IX_Ofertas_ciudadid",
                table: "Ofertas",
                column: "ciudadid");

            migrationBuilder.CreateIndex(
                name: "IX_Ofertas_emprendimientoid",
                table: "Ofertas",
                column: "emprendimientoid");

            migrationBuilder.CreateIndex(
                name: "IX_Ofertas_estadoid",
                table: "Ofertas",
                column: "estadoid");

            migrationBuilder.CreateIndex(
                name: "IX_Ofertas_tipoOfertaid",
                table: "Ofertas",
                column: "tipoOfertaid");

            migrationBuilder.CreateIndex(
                name: "IX_Tarjeta_fkInversor",
                table: "Tarjeta",
                column: "fkInversor");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_rolid",
                table: "Usuario",
                column: "rolid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Colaborador");

            migrationBuilder.DropTable(
                name: "Ofertas");

            migrationBuilder.DropTable(
                name: "Tarjeta");

            migrationBuilder.DropTable(
                name: "TipoIdentificacion");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Ciudad");

            migrationBuilder.DropTable(
                name: "Emprendimiento");

            migrationBuilder.DropTable(
                name: "Estado");

            migrationBuilder.DropTable(
                name: "TipoOferta");

            migrationBuilder.DropTable(
                name: "Inversor");

            migrationBuilder.DropTable(
                name: "Rol");
        }
    }
}
