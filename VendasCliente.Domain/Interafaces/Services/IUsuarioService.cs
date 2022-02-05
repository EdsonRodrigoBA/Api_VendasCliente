using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasCliente.Domain.Models;

namespace VendasCliente.Domain.Interafaces.Services
{
    public interface IUsuarioService
    {

        Task CadastrarAsync(Usuarios model);
        Task<bool> LoginAsync(Usuarios model);

        Task AlterarAsync(Usuarios model);
        Task ExcluirAsync(string id);
        Task<Usuarios> RetornarClientePorId(int Id);
        Task<List<Usuarios>> RetornarPorFiltro(string Id = null, string param = null);
    }
}
