using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasCliente.Domain.Models;

namespace VendasCliente.Domain.Interafaces.Repositories
{
    public interface IVendaRepository
    {
        Task CadastrarAsync(Venda model);
        Task AlterarAsync(Venda model);
        Task ExcluirAsync(string Id);
        Task<Venda> RetornarPorId(int Id);
        Task<List<Venda>> RetornarPorFiltro(string Id = null, string param = null);
        Task CadastrarItemAsync(ItensVenda model);
        Task AlterarItemAsync(ItensVenda model);
        Task ExcluirItemAsync(String Id);
        Task<List<ItensVenda>> RetornarItensPorVenda(string Id);
        Task<bool> Existe(string Id);




    }
}
