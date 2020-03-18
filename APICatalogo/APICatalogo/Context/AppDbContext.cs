using APICatalogo.Models;
using Microsoft.EntityFrameworkCore;

//classe de contexto. 
//Permite coordenar as funcionalidades do Entity.FrameworkCore para o modelo de entidadade

namespace APICatalogo.Context
{
    public class AppDbContext : DbContext
    {
        //cria contexto
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //mapeamento das entidades
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
