using AppVendasBlazor.Model;
using Microsoft.EntityFrameworkCore;

namespace AppVendasBlazor.Data.Context
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        // public DbSet<Pedido> Pedidos { get; set; }
        // public DbSet<ItemVenda> ItemVendas { get; set; }
    }
}
