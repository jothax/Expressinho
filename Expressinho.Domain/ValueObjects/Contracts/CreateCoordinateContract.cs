using Flunt.Validations;

namespace Expressinho.Domain.ValueObjects.Contracts
{
    public class CreateCoordinateContract : Contract<Coordinate>
    {
        public CreateCoordinateContract(Coordinate coordinate)
        {
            // in this case, the api can't input empty coordinates
            Requires()
            .IsNotNullOrEmpty(coordinate.Latitude,"Latitude não pode ser nulo ou vazio")
            .IsNotNullOrEmpty(coordinate.Longitude,"Longitude não pode ser nulo ou vazio");
        }
    }

}