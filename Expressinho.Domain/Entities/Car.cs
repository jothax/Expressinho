using Expressinho.Domain.Entities.Contracts;
using Expressinho.Domain.Enums;

namespace Expressinho.Domain.Entities
{
    public class Car : Entity, IAggregateRoot
    {
        public Car(EModel model, string year, string plate, Guid idMotorist) : base()
        {
            Model = model;
            Year = year;
            Plate = plate;
            IdMotorist = idMotorist;
        }
        public EModel Model {get; private set;}
        
        public string Year {get; private set;}
        
        public string Plate {get; private set;}
        public Guid IdMotorist{get; private set;}
    }
}