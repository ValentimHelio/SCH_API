namespace Api.Domain.Entities;

public class EmpresaEntity : BaseEntity
{
    public string? NomeEmpresa { get; set; }
    public string? Fone { get; set; }
    public string? Cpf { get; set; }

    public EnderecoEntity Endereco { get; set; }
}
