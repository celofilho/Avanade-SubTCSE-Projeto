namespace Avanade.SubTCSE.Projeto.Domain.Agreggates
{
    public record BaseEntity<Tid>
    {
        public Tid Id { get; set; }
    }
}
