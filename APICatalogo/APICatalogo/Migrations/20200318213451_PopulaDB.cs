using Microsoft.EntityFrameworkCore.Migrations;

namespace APICatalogo.Migrations
{
    public partial class Populadb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Categorias(Nome, ImagemUrl) Values('Camisa', 'https://www.google.com.br/images/branding/googlelogo/2x/googlelogo_color_160x56dp.png')");
            migrationBuilder.Sql("Insert into Categorias(Nome, ImagemUrl) Values ('Vestido','https://www.google.com.br/images/branding/googlelogo/2x/googlelogo_color_160x56dp.png')");
            migrationBuilder.Sql("Insert into Categorias(Nome, ImagemUrl) Values ('Bota','https://www.google.com.br/images/branding/googlelogo/2x/googlelogo_color_160x56dp.png')");

            migrationBuilder.Sql("Insert into Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, CategoriaId) Values ('Vestido Um', 'Vestido Curto e Bonito', 69.90, 'https://lojaanimale.vteximg.com.br/arquivos/ids/775935-658-987/07203220_0005_1-VESTIDO-CURTO-TUBINHO-TIRAS-COSTAS.jpg?v=637021157795400000', 10, (Select CategoriaId from Categorias where Nome = 'Vestido'))");

            migrationBuilder.Sql("Insert into Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, CategoriaId) Values ('Coturno', 'Coturno Preto', 299.90,'https://www.cravocanela.com.br/6169-large_default/coturno-preto-85638.jpg', 20, (Select CategoriaId from Categorias where Nome = 'Bota'))");

            migrationBuilder.Sql("Insert into Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, CategoriaId) Values ('Camisa', 'Camisa Florida', 59.90, 'https://22825.cdn.simplo7.net/static/22825/sku/camisas-camisa-floral-masculina-florista--p-1578779504784.png', 50, (Select CategoriaId from Categorias where Nome = 'Camisa'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Categorias");
            migrationBuilder.Sql("Delete from Produtos");

        }
    }
}
