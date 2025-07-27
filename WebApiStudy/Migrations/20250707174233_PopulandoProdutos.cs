using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApiStudy.Migrations
{
    /// <inheritdoc />
    public partial class PopulandoProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "ProdutoId", "CategoriaId", "DataCadastro", "Descricao", "Estoque", "ImagemUrl", "Nome", "Preco" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 7, 7, 17, 42, 33, 199, DateTimeKind.Utc).AddTicks(8863), "Coca cola 2l", 50f, "CocaCola.jpeg", "Coca Cola", 13m },
                    { 2, 2, new DateTime(2025, 7, 7, 17, 42, 33, 199, DateTimeKind.Utc).AddTicks(8869), "Hambúrguer, salada, queijo e tomate com molhos especiais", 50f, "cheeseSalad.jpeg", "Lanches", 15m },
                    { 3, 3, new DateTime(2025, 7, 7, 17, 42, 33, 199, DateTimeKind.Utc).AddTicks(8871), "Um delicioso mousse de maracujá caseiro", 20f, "mousse.jpeg", "Mousse de Maracujá", 8m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 3);
        }
    }
}
