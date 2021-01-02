using Microsoft.EntityFrameworkCore;

namespace ApiProdutos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base() 
        { 
        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Se não estiver configurado no projeto IU pega deginição de chame do json configurado
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(GetStringConectionConfig());
            base.OnConfiguring(optionsBuilder);
        }

        private string GetStringConectionConfig()
        {
            string strCon = "Data Source=DESKTOP-FA2LSQI\\SQLEXPRESS;Initial Catalog=Papelaria;Integrated Security=true";
            return strCon;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
             .Property(p => p.Nome)
             .HasMaxLength(80);

            modelBuilder.Entity<Produto>()
                .Property(p => p.Preco)
                .HasPrecision(10,2);


            modelBuilder.Entity<Produto>()
                   .HasData(
                    new Produto { Id = 1, Nome = "Caderno", Preco = 12.50M, Estoque = 100 },
                    new Produto { Id = 2, Nome = "Caneta", Preco = 2.50M, Estoque = 50 },
                    new Produto { Id = 3, Nome = "Apontador", Preco = 1.80M, Estoque = 80 }
                );
        }

    }
}
