using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasCliente.Domain.Models
{
    public class Produto : EntityBase
    {
        public String Nome { get; set; }
        public String Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade_Estoque { get; set; }
    }
}
