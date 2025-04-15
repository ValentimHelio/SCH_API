using Api.Domain.Entities;
using FluentValidation;

namespace Api.Domain.Validators;

public class EmpresaValidator : AbstractValidator<EmpresaEntity>
{
    public EmpresaValidator()
    {
        RuleFor(e => e.NomeEmpresa)
            .NotEmpty().WithMessage("O nome do empresa deve ser informado")
            .Length(1, 100).WithMessage("O nome da empresa deve ter entre 1 e 100 caracteres");

        RuleFor(e => e.Endereco)
            .NotEmpty().WithMessage("Informe o endereço")
            .MaximumLength(100);

        RuleFor(e => e.Cidade)
            .NotEmpty().WithMessage("Informe a cidade")
            .MaximumLength(100);

        RuleFor(e => e.Uf)
            .NotEmpty().WithMessage("Informe a sigla do estado")
            .Length(2).WithMessage("A UF deve ter 2 caracteres");

        RuleFor(e => e.Cep)
            .NotEmpty().WithMessage("Informe o CEP")
            .MaximumLength(20);

        RuleFor(e => e.Fone)
            .NotEmpty().WithMessage("Informe o Telefone")
            .MaximumLength(20);

        RuleFor(e => e.Cpf)
            .NotEmpty().WithMessage("Informe o CPF")
            .MaximumLength(14);
    }
}
