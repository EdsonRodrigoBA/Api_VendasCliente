using System.Collections.Generic;
using System.Threading.Tasks;
using VendasCliente.Domain.Models;

namespace VendasCliente.Domain.Interafaces.Repositories
{
    public interface IClienteRepository
    {
        Task CadastrarAsync(Cliente model);
        Task AlterarAsync(Cliente model);
        Task ExcluirAsync(Cliente model);
        Task<Cliente> RetornarPorId(int Id);
        Task<List<Cliente>> RetornarPorFiltro(string Id = null, string param= null);

        Task<bool> Existe(string Id);


    }
}
