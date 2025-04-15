using Api.Domain.Entities;
using FluentValidation;

namespace Api.Domain.Validators
{
    public class ServicoValidator : AbstractValidator<ServicoEntity>
    {
        public ServicoValidator()
        {
            RuleFor(s => s.Descricao)
                .NotEmpty().WithMessage("A Descrição deve ser informada")
                .Length(1, 100).WithMessage("A Descrição deve ter entre 1 e 100 caracteres");

            RuleFor(s => s.Tipo)
                .NotEmpty().WithMessage("O Tipo deve ser informado")
                .Length(1, 5).WithMessage("O Tipo deve ter entre 1 e 5 caracteres");

            RuleFor(s => s.EmpresaId)
                .NotEmpty().WithMessage("A Empresa deve ser informada");
        }
    }
}
