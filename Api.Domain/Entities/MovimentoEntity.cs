namespace Api.Domain.Entities;

public class MovimentoEntity : BaseEntity
{
    public int ClienteId { get; set; }
    public virtual ClienteEntity Cliente { get; set; }

    public int ServicoId { get; set; }
    public virtual ServicoEntity Servico { get; set; }

    public DateTime Data { get; set; }

    public decimal Valor_Hora { get; set; }
}
