namespace Api.Domain.Entities;

public class ClienteEntity : BaseEntity
{
    public string Nome { get; set; }
    public string CpfCnpj { get; set; }
    public string? Telefone { get; set; }
    public string? Email { get; set; }

    public int EnderecoId { get; set; }
    public virtual EnderecoEntity Endereco { get; set; }
}
