using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasCliente.Domain.Validation.Base
{
    public static class GetValidations
    {

        public static Response GetErrosValidation(this ValidationResult result)
        {
            var response = new Response();
            if (!result.IsValid)
            {
                foreach (var error in result.Errors)
                {
                    response._report.Add(new Report()
                    {
                        code = error.PropertyName,
                        mensagem = error.ErrorMessage
                    });
                }
                return response;
            }
            return response;

        }
    }
}
