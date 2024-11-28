using Flunt.Validations;

namespace Expressinho.Domain.ValueObjects.Contracts
{
    public class CreateLicenceContract : Contract<Licence>
    {
        public CreateLicenceContract(Licence licence)
        {
            Requires()
            .IsNotNullOrEmpty(licence.RegisterNumber, "Não pode ser nulo ou vazio")
            .IsNotNullOrEmpty(licence.LicenceNumber, "Não pode ser nulo ou vazio");
        }
    }
}