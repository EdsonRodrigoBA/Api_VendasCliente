using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasCliente.Domain.Models;

namespace VendasCliente.Domain.Interafaces.Repositories
{
    public interface IProdutoRepository
    {
        Task CadastrarAsync(Produto model);
        Task AlterarAsync(Produto model);
        Task ExcluirAsync(string id);
        Task<Produto> RetornarPorId(int Id);
        Task<List<Produto>> RetornarPorFiltro(string Id = null, string param = null);
        Task<bool> Existe(string Id);

    }
}
