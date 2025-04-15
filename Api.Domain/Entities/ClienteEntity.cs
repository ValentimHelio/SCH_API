namespace Api.Domain.Entities;

public class ClienteEntity : BaseEntity
{
    public string? NomeCliente { get; set; }
    public string? Endereco { get; set; }
    public string? Cidade { get; set; }
    public string? Uf { get; set; }
    public string? Cep { get; set; }
    public string? Fone { get; set; }
    public string? Cpf { get; set; }
}
