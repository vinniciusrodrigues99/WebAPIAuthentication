using Microsoft.EntityFrameworkCore;
using WebApiStudy.Domain;

namespace WebApiStudy.Context;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Categoria> Categorias { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //popular com dados iniciais
        base.OnModelCreating(modelBuilder);
        SeedData(modelBuilder);
    }

    private void SeedData(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Produto>().HasData(
            new Produto {ProdutoId = 1, Nome = "Coca Cola", Descricao = "Coca cola 2l", CategoriaId = 1, Preco = 13, Estoque = 50, DataCadastro = DateTime.UtcNow, ImagemUrl = "CocaCola.jpeg"},
            new Produto {ProdutoId = 2, Nome = "Lanches", Descricao = "Hambúrguer, salada, queijo e tomate com molhos especiais", CategoriaId = 2, Preco = 15, Estoque = 50, DataCadastro = DateTime.UtcNow, ImagemUrl = "cheeseSalad.jpeg"},
            new Produto {ProdutoId = 3, Nome = "Mousse de Maracujá", Descricao = "Um delicioso mousse de maracujá caseiro", CategoriaId = 3, Preco = 8, Estoque = 20, DataCadastro = DateTime.UtcNow, ImagemUrl = "mousse.jpeg"});
    }
}