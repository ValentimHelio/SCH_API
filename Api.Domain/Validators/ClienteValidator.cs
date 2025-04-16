using Api.Domain.Entities;
using FluentValidation;

namespace Api.Domain.Validators;

public class ClienteValidator : AbstractValidator<ClienteEntity>
{
    public ClienteValidator()
    {
        RuleFor(c => c.NomeCliente)
                .NotEmpty().WithMessage("O nome do cliente deve ser informado")
                .Length(1, 100).WithMessage("O nome deve ter entre 1 e 100 caracteres");

        RuleFor(c => c.Fone)
            .NotEmpty().WithMessage("O telefone deve ser informado")
            .MaximumLength(20).WithMessage("O telefone deve ter no máximo 20 caracteres");

        RuleFor(c => c.Cpf)
            .NotEmpty().WithMessage("O CPF deve ser informado")
            .MaximumLength(14).WithMessage("O CPF deve ter no máximo 14 caracteres");

        RuleFor(c => c.Endereco)
            .SetValidator(new EnderecoValidator());
    }
}
