using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities;

public abstract class BaseEntity
{
    [Key]
    [Display(Name = "Código")]
    public int Id { get; set; }

    private DateTime _creatAt;

    public DateTime CreateAt
    {
        get { return _creatAt; }
        set { _creatAt = (value.Equals(null) ? DateTime.UtcNow : value); }
    }

    public DateTime? UpdateAt { get; set; }
    public bool IsDeleted { get; set; }
}
