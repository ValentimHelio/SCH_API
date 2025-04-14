using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Domain.Entities;

[Table("movimento")]
public class MovimentoEntity : BaseEntity
{
    [Required(ErrorMessage = "O Cliente deve ser informado")]
    [Display(Name = "Cliente")]
    public int ClienteId { get; set; }

    [Display(Name = "Cliente")]
    public virtual ClienteEntity cliente { get; set; }

    [Required(ErrorMessage = "O Serviço deve ser informado")]
    [Display(Name = "Serviço")]

    public int ServicoId { get; set; }
    [Display(Name = "Serviço")]
    public virtual ServicoEntity servico { get; set; }

    [Display(Name = "Data")]
    public DateTime Data { get; set; }

    [Required(ErrorMessage = "O Valor deve ser informado")]
    [Display(Name = "Valor")]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Valor_Hora { get; set; }
}
