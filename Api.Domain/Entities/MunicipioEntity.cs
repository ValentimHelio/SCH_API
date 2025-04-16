namespace Api.Domain.Entities
{
    public class MunicipioEntity : BaseEntity
    {
        public string Nome { get; set; }

        public int EstadoId { get; set; }
        public virtual EstadoEntity Estado { get; set; }
    }
}
