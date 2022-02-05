using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasCliente.Domain.Models
{
    public class Venda : EntityBase
    {

        public Cliente cliente { get; set; }
        public Usuarios usuarios { get; set; }
        public List<ItensVenda> itensVenda { get; set; }

    }
}
