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
    public class VendaService : IVendaServices
    {
        private readonly IVendaRepository _ivendaRepository;

        public VendaService(IVendaRepository ivendaRepository)
        {
            _ivendaRepository = ivendaRepository;
        }

        public Task AlterarAsync(Venda model)
        {
            throw new NotImplementedException();
        }

        public Task CadastrarAsync(Venda model)
        {
            throw new NotImplementedException();
        }

        public Task ExcluirAsync(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Venda>> RetornarPorFiltro(string Id = null, string param = null)
        {
            throw new NotImplementedException();
        }

        public Task<Venda> RetornarPorId(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
