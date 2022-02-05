using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasCliente.Domain.Models;
using VendasCliente.Domain.Validation.Base;

namespace VendasCliente.Domain.Interafaces.Services
{
    public interface IClienteServices
    {
        Task<Response> CadastrarAsync(Cliente model);
        Task<Response> AlterarAsync(Cliente model);
        Task<Response> ExcluirAsync(string id);
        Task<Response<Cliente>> RetornarClientePorId(int Id);
        Task<Response<List<Cliente>>> RetornarPorFiltro(string Id = null, string param = null);
    }
}
