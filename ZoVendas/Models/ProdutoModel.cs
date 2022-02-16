using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZoVendas.Models
{
    public class ProdutoModel
    {
        public ProdutoModel() { }
        public int ID { get; set; }
        public String Nome { get; set; }
        public String Tipo { get; set; }
        public int QuantidadeProduto { get; set; }
        public float ValorProduto { get; set; }
                
    }
}
