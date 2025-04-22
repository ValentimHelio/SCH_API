namespace Api.Domain.Entities;

public class ClienteEntity : BaseEntity
{
    public string? NomeCliente { get; set; }
    public string? Fone { get; set; }
    public string? Cpf { get; set; }

    public int EnderecoId { get; set; }
    public virtual EnderecoEntity Endereco { get; set; }
}
