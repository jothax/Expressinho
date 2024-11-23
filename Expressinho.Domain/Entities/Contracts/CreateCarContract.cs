using Flunt.Validations;

namespace Expressinho.Domain.Entities.Contracts
{
    public class CreateCarContract : Contract<Car>
    {
        public CreateCarContract(Car car)
        {
            Requires()
            .IsNotNullOrEmpty(car.Model,"Model")
            .IsNotNullOrEmpty(car.Year, "Year")
            .IsNotNullOrEmpty(car.Plate, "Plate");
        }   
    }
}