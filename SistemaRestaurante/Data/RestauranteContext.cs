using Microsoft.EntityFrameworkCore;
using SistemaRestaurante.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRestaurante.Data
{
    public class RestauranteContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Comanda> Comandas { get; set; }
        public DbSet<ItemPedido> ItemPedidos { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }

        public DbSet<FechamentoCaixa> FechamentoCaixas { get; set; }

        public RestauranteContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string caminhoProjeto = Path.GetFullPath(
                Path.Combine(AppContext.BaseDirectory, @"..\..\..\", "Restaurante.db"));

            options.UseSqlite($"Data Source={caminhoProjeto}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemPedido>().HasOne(i => i.Produto).WithMany().HasForeignKey(i => i.ProdutoId);

            modelBuilder.Entity<ItemPedido>().HasOne(i => i.Comanda).WithMany(c => c.Itens).HasForeignKey(i => i.ComandaId);

            modelBuilder.Entity<Comanda>().HasOne(c => c.Pagamento).WithOne(p => p.Comanda).HasForeignKey<Pagamento>(p => p.ComandaId);
        }
    }
}
