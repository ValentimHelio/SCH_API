using Api.Domain.Entities;
using FluentValidation;

namespace Api.Domain.Validators;

public class EnderecoValidator : AbstractValidator<EnderecoEntity>
{
    public EnderecoValidator()
    {
        RuleFor(e => e.Logradouro)
            .NotEmpty().WithMessage("Logradouro é obrigatório.")
            .MaximumLength(100).WithMessage("Logradouro deve ter no máximo 100 caracteres.");

        RuleFor(e => e.Numero)
            .NotEmpty().WithMessage("Número é obrigatório.")
            .MaximumLength(10).WithMessage("Número deve ter no máximo 10 caracteres.");

        RuleFor(e => e.Cep)
            .NotEmpty().WithMessage("CEP é obrigatório.")
            .MaximumLength(20).WithMessage("CEP deve ter no máximo 20 caracteres.");

        RuleFor(e => e.EstadoId)
            .GreaterThan(0).WithMessage("Estado é obrigatório.");

        RuleFor(e => e.MunicipioId)
            .GreaterThan(0).WithMessage("Município é obrigatório.");
    }
}
