namespace Api.Domain.Entities
{
    public class EstadoEntity : BaseEntity
    {
        public string Nome { get; set; }
        public string Uf { get; set; }

        public virtual ICollection<MunicipioEntity> Municipios { get; set; }
    }
}
