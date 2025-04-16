using Api.Domain.Entities;
using FluentValidation;

namespace Api.Domain.Validators;

public class EmpresaValidator : AbstractValidator<EmpresaEntity>
{
    public EmpresaValidator()
    {
        RuleFor(e => e.NomeEmpresa)
            .NotEmpty().WithMessage("O nome da empresa deve ser informado")
            .MaximumLength(100);

        RuleFor(e => e.Fone)
            .NotEmpty().WithMessage("O telefone deve ser informado")
            .MaximumLength(20);

        RuleFor(e => e.Cpf)
            .NotEmpty().WithMessage("O CPF deve ser informado")
            .MaximumLength(14);

        RuleFor(e => e.Endereco)
            .SetValidator(new EnderecoValidator());
    }
}
