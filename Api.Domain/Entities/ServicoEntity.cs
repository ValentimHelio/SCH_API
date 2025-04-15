using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Domain.Entities;

public class ServicoEntity : BaseEntity
{
    public string? Descricao { get; set; }
    public string? Tipo { get; set; }
    public int EmpresaId { get; set; }
    public virtual EmpresaEntity Empresa { get; set; }
}
