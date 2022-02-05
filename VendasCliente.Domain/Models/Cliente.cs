using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasCliente.Domain.Models
{
    public class Cliente : EntityBase
    {
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Telefone { get; set; }
    }
}
