using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasCliente.Domain.Interafaces.Repositories;
using VendasCliente.Domain.Interafaces.Services;
using VendasCliente.Domain.Models;
using VendasCliente.Domain.Validation;
using VendasCliente.Domain.Validation.Base;

namespace VendasCliente.Domain.Services
{
    public class ClienteService : IClienteServices
    {
        private readonly IClienteRepository _iclienteRepository;

        public ClienteService(IClienteRepository iclienteRepository)
        {
            _iclienteRepository = iclienteRepository;
        }

        public Task<Response> AlterarAsync(Cliente model)
        {
            throw new NotImplementedException();
        }

        public async Task<Response> CadastrarAsync(Cliente model)
        {
            var response = new Response();
            var validaModel = new ClienteValidation();
            var resultValidacao = await validaModel.ValidateAsync(model);
            if (!resultValidacao.IsValid)
            {
                foreach (var error in resultValidacao.Errors)
                {
                    response._report.Add(new Report()
                    {
                        code = error.PropertyName,
                        mensagem = error.ErrorMessage
                    });
                }
            }

             await _iclienteRepository.CadastrarAsync(model);
            return response;
        }

        public Task<Response> ExcluirAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<Cliente>> RetornarClientePorId(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<Cliente>>> RetornarPorFiltro(string Id = null, string param = null)
        {
            throw new NotImplementedException();
        }
    }
}
