namespace Api.Domain.Entities;

public class EnderecoEntity : BaseEntity
{
    public string Logradouro { get; set; }
    public string Numero { get; set; }
    public string? Complemento { get; set; }
    public string Cep { get; set; }

    public int EstadoId { get; set; }
    public virtual EstadoEntity Estado { get; set; }

    public int MunicipioId { get; set; }
    public virtual MunicipioEntity Municipio { get; set; }

    // Opcional: Relacionamento reverso (caso necessário)
    // public virtual ICollection<EmpresaEntity> Empresas { get; set; }
}
