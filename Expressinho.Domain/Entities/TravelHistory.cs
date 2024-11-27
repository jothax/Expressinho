namespace Expressinho.Domain.Entities
{
    public class TravelHistory : Entity
    {
        public TravelHistory(Guid idTravel, Guid idPassager, Guid idMotorist)
        {
            IdTravel = idTravel;
            IdPassager = idPassager;
            IdMotorist = idMotorist;
        }
        public Guid IdTravel{get; private set;}
        public Guid IdPassager{get; private set;}
        public Guid IdMotorist{get; private set;}
    }
}