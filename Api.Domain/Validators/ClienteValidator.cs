using Api.Domain.Entities;
using FluentValidation;

namespace Api.Domain.Validators;

public class ClienteValidator : AbstractValidator<ClienteEntity>
{
    public ClienteValidator()
    {
        RuleFor(c => c.Nome)
            .NotEmpty().WithMessage("Nome do cliente é obrigatório.")
            .MaximumLength(100).WithMessage("Nome do cliente deve ter no máximo 100 caracteres.");

        RuleFor(c => c.CpfCnpj)
            .NotEmpty().WithMessage("CPF/CNPJ é obrigatório.")
            .MaximumLength(20).WithMessage("CPF/CNPJ deve ter no máximo 20 caracteres.");

        RuleFor(c => c.Telefone)
            .MaximumLength(20).WithMessage("Telefone deve ter no máximo 20 caracteres.");

        RuleFor(c => c.Email)
            .MaximumLength(100).WithMessage("Email deve ter no máximo 100 caracteres.")
            .EmailAddress().When(c => !string.IsNullOrEmpty(c.Email))
            .WithMessage("Formato de email inválido.");

        RuleFor(c => c.EnderecoId)
            .GreaterThan(0).WithMessage("Endereço é obrigatório.");
    }
}
