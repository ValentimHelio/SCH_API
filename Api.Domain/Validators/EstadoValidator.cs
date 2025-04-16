using Api.Domain.Entities;
using FluentValidation;

namespace Api.Domain.Validators
{
    public class EstadoValidator : AbstractValidator<EstadoEntity>
    {
        public EstadoValidator()
        {
            RuleFor(e => e.Nome)
                .NotEmpty().WithMessage("O nome do estado deve ser informado")
                .MaximumLength(100).WithMessage("O nome do estado deve ter no máximo 100 caracteres");

            RuleFor(e => e.Uf)
                .NotEmpty().WithMessage("A sigla do estado (UF) deve ser informada")
                .Length(2).WithMessage("A sigla do estado (UF) deve conter exatamente 2 caracteres")
                .Matches("^[A-Z]{2}$").WithMessage("A sigla deve conter apenas letras maiúsculas");
        }
    }
}
