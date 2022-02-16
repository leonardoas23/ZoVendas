using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZoVendas.Models
{
    public class ItensPedidoModel 
    {
        public ItensPedidoModel() { }
        public int ID { get; set; }
        public ProdutoModel Produto { get; set; }

        public int IdProduto { get; set; }
        public int QtdProduto { get; set; }

        
                
    }
}
