using Microsoft.EntityFrameworkCore.Migrations;

namespace back_end.Migrations
{
    public partial class puntuacionId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Peliculas_PeliculaId1",
                table: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_PeliculaId1",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "PeliculaId1",
                table: "Ratings");

            migrationBuilder.AlterColumn<int>(
                name: "PeliculaId",
                table: "Ratings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_PeliculaId",
                table: "Ratings",
                column: "PeliculaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Peliculas_PeliculaId",
                table: "Ratings",
                column: "PeliculaId",
                principalTable: "Peliculas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Peliculas_PeliculaId",
                table: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_PeliculaId",
                table: "Ratings");

            migrationBuilder.AlterColumn<string>(
                name: "PeliculaId",
                table: "Ratings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "PeliculaId1",
                table: "Ratings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_PeliculaId1",
                table: "Ratings",
                column: "PeliculaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Peliculas_PeliculaId1",
                table: "Ratings",
                column: "PeliculaId1",
                principalTable: "Peliculas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
