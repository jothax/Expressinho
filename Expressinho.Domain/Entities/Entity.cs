using Expressinho.Domain.Entities.Contracts;
using Flunt.Notifications;

namespace Expressinho.Domain.Entities

{
    public abstract class Entity : Notifiable<Notification>, IEntity ,IEquatable<Entity> 
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id {get; private set;}


        bool IEquatable<Entity>.Equals(Entity? other)
        {
            if(other == null) 
                return false;
            
            return Id == other.Id;
        }
    }
}