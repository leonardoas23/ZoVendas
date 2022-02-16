using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZoVendas.Models
{
    public class ClienteModel
    {
        public ClienteModel() { }
        
        public int ID { get; set; }

        public List<PedidoModel> Pedidos { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Endereco { get; set; }
        public String Foto { get; set; }
        public int Telefone { get; set; }
        public float DividaTotal { get; set; }
        
                
    }
}
