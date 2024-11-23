using Flunt.Validations;

namespace Expressinho.Domain.ValueObjects.Contracts
{
    public class CreateNameContract : Contract<Name>
    {
        public CreateNameContract(Name name)
        {
            Requires()
                .IsNotNullOrEmpty(name.FirstName, "FirstName")
                .IsLowerThan(name.FirstName.Length,3,"FirstName length min invalid")
                .IsGreaterThan(name.FirstName.Length, 50,"FirstName length max invalid")
                .IsNotNullOrEmpty(name.LastName, "LastName")
                .IsLowerThan(name.LastName.Length,3,"LastName length min invalid")
                .IsGreaterThan(name.LastName.Length, 50,"LastName length max invalid");
        }
    }
}