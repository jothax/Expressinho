namespace Expressinho.Viagem.Domain.Entities
{
    public abstract class Entity : IEquatable<Entity>
    {
        public Guid Id {get; set;}

        bool IEquatable<Entity>.Equals(Entity? other)
        {
            if(other == null)
                return false;
            return Id == other.Id;
        }
    }
}