using Api.Domain.Entities;
using FluentValidation;

namespace Api.Domain.Validators
{
    public class MunicipioValidator : AbstractValidator<MunicipioEntity>
    {
        public MunicipioValidator()
        {
            RuleFor(m => m.Nome)
                .NotEmpty().WithMessage("O nome do município deve ser informado")
                .MaximumLength(100).WithMessage("O nome do município deve ter no máximo 100 caracteres");

            RuleFor(m => m.EstadoId)
                .GreaterThan(0).WithMessage("O Estado deve ser informado");
        }
    }
}
