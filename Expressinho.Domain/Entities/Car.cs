using Expressinho.Domain.Entities.Contracts;

namespace Expressinho.Domain.Entities
{
    public class Car : Entity, IAggregateRoot
    {
        public Car(string model, string year, string plate, Motorist motorist) : base()
        {
            Model = model;
            Year = year;
            Plate = plate;
            Motorist = motorist;
        }
        public string Model {get; private set;}
        
        public string Year {get; private set;}
        
        public string Plate {get; private set;}
        public Motorist Motorist{get; private set;}
    }
}