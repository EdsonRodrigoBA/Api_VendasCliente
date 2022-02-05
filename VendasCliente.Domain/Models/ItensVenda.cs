using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasCliente.Domain.Models
{
    public class ItensVenda : EntityBase
    {
        public Produto produto { get; set; }
        public Venda Venda { get; set; }
        public int quantidade { get; set; }
        public decimal valor { get; set; }
    }
}
