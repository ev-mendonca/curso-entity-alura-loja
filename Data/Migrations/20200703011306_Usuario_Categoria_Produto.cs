using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Usuario_Categoria_Produto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriaID",
                table: "Produto",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Produto",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<byte[]>(
                name: "Imagem2",
                table: "Produto",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Imagem3",
                table: "Produto",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ImagemPrincipal",
                table: "Produto",
                nullable: false,
                defaultValue: new byte[] {  });

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 200, nullable: false),
                    ImagemHome = table.Column<byte[]>(nullable: false),
                    Banner = table.Column<byte[]>(nullable: false),
                    CategoriaPaiID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Categoria_Categoria_CategoriaPaiID",
                        column: x => x.CategoriaPaiID,
                        principalTable: "Categoria",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 255, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: false),
                    Senha = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produto_CategoriaID",
                table: "Produto",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_Categoria_CategoriaPaiID",
                table: "Categoria",
                column: "CategoriaPaiID");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Categoria_CategoriaID",
                table: "Produto",
                column: "CategoriaID",
                principalTable: "Categoria",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Categoria_CategoriaID",
                table: "Produto");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Produto_CategoriaID",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "CategoriaID",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "Imagem2",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "Imagem3",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "ImagemPrincipal",
                table: "Produto");
        }
    }
}
