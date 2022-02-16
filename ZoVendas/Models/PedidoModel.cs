using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZoVendas.Models
{
    public class PedidoModel 
    {
        public PedidoModel() { }
        public int ID { get; set; }
        public List<ItensPedidoModel> Produtos { get; set; }
        public DateTime Data { get; set; }
        public String Status { get; set; }
        public ClienteModel Cliente  { get; set; }

        public int IdCliente { get; set; }
        public float ValorTotal { get; set; }
        public string MetodoPagamento { get; set; }
                
    }
}
