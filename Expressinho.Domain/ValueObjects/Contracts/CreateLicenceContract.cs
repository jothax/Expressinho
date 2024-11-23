using Flunt.Validations;

namespace Expressinho.Domain.ValueObjects.Contracts
{
    public class CreateLicenceContract : Contract<Licence>
    {
        public CreateLicenceContract(Licence licence)
        {
            Requires()
            .IsNotNullOrEmpty(licence.RegisterNumber, "Register Number can't is null or empty")
            .IsNotNullOrEmpty(licence.LicenceNumber, "Licence Number can't is null or empty");
        }
    }
}