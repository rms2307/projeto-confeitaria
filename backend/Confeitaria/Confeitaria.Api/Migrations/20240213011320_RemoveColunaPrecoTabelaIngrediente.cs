using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Confeitaria.Api.Migrations
{
    /// <inheritdoc />
    public partial class RemoveColunaPrecoTabelaIngrediente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Preco",
                table: "Ingredientes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Preco",
                table: "Ingredientes",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
