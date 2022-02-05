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
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _iusuarioRepository;

        public UsuarioService(IUsuarioRepository iusuarioRepository)
        {
            _iusuarioRepository = iusuarioRepository;
        }

        public Task AlterarAsync(Usuarios model)
        {
            throw new NotImplementedException();
        }

        public Task CadastrarAsync(Usuarios model)
        {
            throw new NotImplementedException();
        }

        public Task ExcluirAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> LoginAsync(Usuarios model)
        {
            throw new NotImplementedException();
        }

        public Task<Usuarios> RetornarClientePorId(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Usuarios>> RetornarPorFiltro(string Id = null, string param = null)
        {
            throw new NotImplementedException();
        }
    }
}
