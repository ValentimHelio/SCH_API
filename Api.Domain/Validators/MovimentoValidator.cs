using Api.Domain.Entities;
using FluentValidation;

namespace Api.Domain.Validators
{
    public class MovimentoValidator : AbstractValidator<MovimentoEntity>
    {
        public MovimentoValidator()
        {
            RuleFor(m => m.ClienteId)
                .NotEmpty().WithMessage("O Cliente deve ser informado");

            RuleFor(m => m.ServicoId)
                .NotEmpty().WithMessage("O Serviço deve ser informado");

            RuleFor(m => m.Data)
                .NotEmpty().WithMessage("A Data deve ser informada");

            RuleFor(m => m.Valor_Hora)
                .GreaterThan(0).WithMessage("O Valor deve ser maior que zero");
        }
    }
}
