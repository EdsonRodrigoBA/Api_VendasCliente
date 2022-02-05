using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasCliente.Domain.Models;

namespace VendasCliente.Domain.Interafaces.Services
{
    public interface IVendaServices
    {
        Task CadastrarAsync(Venda model);
        Task AlterarAsync(Venda model);
        Task ExcluirAsync(string Id);
        Task<Venda> RetornarPorId(int Id);
        Task<List<Venda>> RetornarPorFiltro(string Id = null, string param = null);
    }
}
