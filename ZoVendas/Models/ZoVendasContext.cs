
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZoVendas.Models
{
    public class ZoVendasContext : DbContext
    {
        public ZoVendasContext(DbContextOptions<ZoVendasContext> options) : base(options) { }
        public DbSet<ProdutoModel> Produto { get; set; }
        public DbSet<ClienteModel> Cliente { get; set; }
        public DbSet<PedidoModel> Pedido { get; set; }

        public DbSet<ItensPedidoModel> Carrinho { get; set; }
    }
}
