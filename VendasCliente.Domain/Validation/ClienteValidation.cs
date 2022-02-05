using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasCliente.Domain.Models;

namespace VendasCliente.Domain.Validation
{
    public class ClienteValidation : AbstractValidator<Cliente>
    {
        public ClienteValidation()
        {
            RuleFor(x => x.Email)
                .NotNull()
                .NotEmpty()
                .EmailAddress(FluentValidation.Validators.EmailValidationMode.AspNetCoreCompatible)
                .WithMessage("O E-mail é obrigatorio");

            RuleFor(x => x.Nome)
                .NotNull()
                .NotEmpty()
                .WithMessage("O nome é obrigatorio");

            RuleFor(x => x.Telefone)
                .NotNull()
                .NotEmpty()
                
                .WithMessage("O telefone é obrigatorio");
        }
    }
}
