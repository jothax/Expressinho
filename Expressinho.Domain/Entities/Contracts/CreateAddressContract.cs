using Flunt.Validations;

namespace Expressinho.Domain.Entities.Contracts
{
    public class CreateAddressContract : Contract<Address>
    {
        public CreateAddressContract(Address address)
        {
            Requires()
            .IsNotNullOrEmpty(address.Number, "number can't null or empty")
            .IsNotNullOrEmpty(address.Street, "Street can't null or empty")
            .IsNotNullOrEmpty(address.City, "City can't null or empty")
            .IsNotNullOrEmpty(address.State, "State can't null or empty")
            .IsNotNullOrEmpty(address.Zipcode, "Zipcode can't null or empty")
            .IsLowerThan(address.Street.Length, 3,"Street length is lower than 3")
            .IsLowerThan(address.City.Length,3,"City length is lower than 3")
            .IsLowerThan(address.State.Length,2,"State length is lower than 2")
            .IsLowerThan(address.Zipcode.Length,8,"Zipcode length is lower than 8")
            .IsGreaterThan(address.Number, 8, "Number can't gretter than 8")
            .IsGreaterThan(address.Street, 25, "Street can't gretter than 25")
            .IsGreaterThan(address.City, 15, "City can't gretter than 15")
            .IsGreaterThan(address.State, 15, "State can't gretter than 15")
            .IsGreaterThan(address.Zipcode, 9, "Zipcode can't gretter than 9")
            ;
        }
    }
}