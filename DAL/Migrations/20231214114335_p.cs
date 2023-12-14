using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class p : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Elementos",
                columns: table => new
                {
                    idElemento = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    codigoElemento = table.Column<string>(type: "text", nullable: false),
                    nombreElemento = table.Column<string>(type: "text", nullable: false),
                    descripcionElemento = table.Column<string>(type: "text", nullable: false),
                    cantidadElemento = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elementos", x => x.idElemento);
                });

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    idReserva = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fchReserva = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.idReserva);
                });

            migrationBuilder.CreateTable(
                name: "Rel_Elemento_Reservas",
                columns: table => new
                {
                    ElementoidElemento = table.Column<long>(type: "bigint", nullable: false),
                    ReservasidReserva = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rel_Elemento_Reservas", x => new { x.ElementoidElemento, x.ReservasidReserva });
                    table.ForeignKey(
                        name: "FK_Rel_Elemento_Reservas_Elementos_ElementoidElemento",
                        column: x => x.ElementoidElemento,
                        principalTable: "Elementos",
                        principalColumn: "idElemento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rel_Elemento_Reservas_Reservas_ReservasidReserva",
                        column: x => x.ReservasidReserva,
                        principalTable: "Reservas",
                        principalColumn: "idReserva",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rel_Elemento_Reservas_ReservasidReserva",
                table: "Rel_Elemento_Reservas",
                column: "ReservasidReserva");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rel_Elemento_Reservas");

            migrationBuilder.DropTable(
                name: "Elementos");

            migrationBuilder.DropTable(
                name: "Reservas");
        }
    }
}
