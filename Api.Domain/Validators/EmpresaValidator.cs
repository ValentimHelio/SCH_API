using Api.Domain.Entities;
using FluentValidation;

namespace Api.Domain.Validators;

public class EmpresaValidator : AbstractValidator<EmpresaEntity>
{
    public EmpresaValidator()
    {
        RuleFor(e => e.NomeEmpresa)
            .NotEmpty().WithMessage("Nome da empresa é obrigatório.")
            .MaximumLength(100).WithMessage("Nome da empresa deve ter no máximo 100 caracteres.");

        RuleFor(e => e.Fone)
            .NotEmpty().WithMessage("Telefone é obrigatório.")
            .MaximumLength(20).WithMessage("Telefone deve ter no máximo 20 caracteres.");

        RuleFor(e => e.Cpf)
            .NotEmpty().WithMessage("CPF é obrigatório.")
            .MaximumLength(14).WithMessage("CPF deve ter no máximo 14 caracteres.");

        RuleFor(e => e.EnderecoId)
            .GreaterThan(0).WithMessage("Endereço é obrigatório.");
    }
}
