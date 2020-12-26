using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotecaAPI.Migrations
{
    public partial class AlteracaoTblLivro2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Livros",
                table: "Livros");

            migrationBuilder.RenameTable(
                name: "Livros",
                newName: "Livro");

            migrationBuilder.AlterColumn<string>(
                name: "NomeLivro",
                table: "Livro",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Autor",
                table: "Livro",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AnoPublicacao",
                table: "Livro",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Livro",
                table: "Livro",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Livro",
                table: "Livro");

            migrationBuilder.DropColumn(
                name: "AnoPublicacao",
                table: "Livro");

            migrationBuilder.RenameTable(
                name: "Livro",
                newName: "Livros");

            migrationBuilder.AlterColumn<string>(
                name: "NomeLivro",
                table: "Livros",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Autor",
                table: "Livros",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Livros",
                table: "Livros",
                column: "Id");
        }
    }
}
