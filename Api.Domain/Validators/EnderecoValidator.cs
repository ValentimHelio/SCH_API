using Api.Domain.Entities;
using FluentValidation;

namespace Api.Domain.Validators;

public class EnderecoValidator : AbstractValidator<EnderecoEntity>
{
    public EnderecoValidator()
    {
        RuleFor(e => e.Logradouro)
            .NotEmpty().WithMessage("O logradouro deve ser informado")
            .MaximumLength(100);

        RuleFor(e => e.Cep)
            .NotEmpty().WithMessage("O CEP deve ser informado")
            .MaximumLength(20);

        RuleFor(e => e.EstadoId)
            .GreaterThan(0).WithMessage("O Estado deve ser informado");

        RuleFor(e => e.MunicipioId)
            .GreaterThan(0).WithMessage("O Município deve ser informado");
    }
}
