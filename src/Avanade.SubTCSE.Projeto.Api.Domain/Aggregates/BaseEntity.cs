

namespace Avanade.SubTCSE.Projeto.Api.Domain.Aggregates.Employee.Entities
{
    public record BaseEntity<Tid>
    {
        public Tid Id { get; set; }
    }
}
