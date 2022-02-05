using System.Collections.Generic;
using System.Threading.Tasks;
using VendasCliente.Domain.Models;

namespace VendasCliente.Domain.Interafaces.Repositories
{
    public interface IUsuarioRepository
    {
        Task CadastrarAsync(Usuarios model);
        Task AlterarAsync(Usuarios model);
        Task ExcluirAsync(string id);
        Task<Usuarios> RetornarClientePorId(int Id);
        Task<List<Usuarios>> RetornarPorFiltro(string Id = null, string param= null);
        Task<bool> Existe(string Id);



    }
}
