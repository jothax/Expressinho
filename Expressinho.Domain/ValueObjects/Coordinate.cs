using Expressinho.Domain.ValueObjects.Contracts;

namespace Expressinho.Domain.ValueObjects
{
    public class Coordinate : ValueObjects
    {
        public Coordinate(string latitude, string longitude)
        {
            Latitude = latitude;
            Longitude = longitude;

            AddNotifications(new CreateCoordinateContract(this));
        }

        public string Latitude{get; private set;}
        public string Longitude{get; private set;}
    }
}