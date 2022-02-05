using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasCliente.Domain.Interafaces.Repositories;
using VendasCliente.Domain.Interafaces.Services;
using VendasCliente.Domain.Models;

namespace VendasCliente.Domain.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public Task AlterarAsync(Produto model)
        {
            throw new NotImplementedException();
        }

        public Task CadastrarAsync(Produto model)
        {
            throw new NotImplementedException();
        }

        public Task ExcluirAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Existe(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Produto>> RetornarPorFiltro(string Id = null, string param = null)
        {
            throw new NotImplementedException();
        }

        public Task<Produto> RetornarPorId(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
