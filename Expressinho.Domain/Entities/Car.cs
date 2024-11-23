using Expressinho.Domain.Entities.Contracts;

namespace Expressinho.Domain.Entities
{
    public class Car : Entity 
    {
        public Car(string model, string year, string plate) : base()
        {
            Model = model;
            Year = year;
            Plate = plate;

            AddNotifications(new CreateCarContract(this));
        }
        public string Model {get; private set;}
        
        public string Year {get; private set;}
        
        public string Plate {get; private set;}
    }
}