using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasCliente.Domain.Models
{
    public class Usuarios : EntityBase
    {
        public String Nome { get; set; }
        public String Login { get; set; }
        public String Senha { get; set; }

    }
}
