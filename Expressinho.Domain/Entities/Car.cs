namespace Expressinho.Domain.Entities
{
    public class Car : Entity 
    {
        public Car(string model, string year, string plate, Guid idMotorist) : base()
        {
            Model = model;
            Year = year;
            Plate = plate;
            IdMotorist = idMotorist;
        }
        public string Model {get; private set;}
        
        public string Year {get; private set;}
        
        public string Plate {get; private set;}
        public Guid IdMotorist{get; private set;}
    }
}