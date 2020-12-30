using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AcademiaFit.Migrations
{
    public partial class PopulaTabelaPlanos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Planos(Nome,Valor)Values('Plano A',60)");
            migrationBuilder.Sql("INSERT INTO Planos(Nome,Valor)Values('Plano B',80)");
            migrationBuilder.Sql("INSERT INTO Planos(Nome,Valor)Values('Plano C',100)");
            migrationBuilder.Sql("INSERT INTO Planos(Nome,Valor)Values('Plano D',150)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Planos");
        }
    }
}
