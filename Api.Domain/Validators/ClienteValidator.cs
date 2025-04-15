using Api.Domain.Entities;
using FluentValidation;

namespace Api.Domain.Validators;

public class ClienteValidator : AbstractValidator<ClienteEntity>
{
    public ClienteValidator()
    {
        RuleFor(x => x.NomeCliente)
            .NotEmpty().WithMessage("O nome do cliente deve ser informado")
            .Length(1, 100).WithMessage("O nome do cliente deve ter entre 1 e 100 caracteres");

        RuleFor(x => x.Endereco)
            .NotEmpty().WithMessage("Informe o endereço")
            .MaximumLength(100);

        RuleFor(x => x.Cidade)
            .NotEmpty().WithMessage("Informe a cidade")
            .MaximumLength(100);

        RuleFor(x => x.Uf)
            .NotEmpty().WithMessage("Informe a sigla do estado")
            .Length(2);

        RuleFor(x => x.Cep)
            .NotEmpty().WithMessage("Informe o CEP")
            .MaximumLength(20);

        RuleFor(x => x.Fone)
            .NotEmpty().WithMessage("Informe o Telefone")
            .MaximumLength(20);

        RuleFor(x => x.Cpf)
            .NotEmpty().WithMessage("Informe o Cpf")
            .MaximumLength(14);
    }
}

