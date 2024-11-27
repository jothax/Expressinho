using Flunt.Validations;

namespace Expressinho.Domain.ValueObjects.Contracts
{
    public class CreateLicenceContract : Contract<Licence>
    {
        public CreateLicenceContract(Licence licence)
        {
            Requires()
            .IsNotNullOrEmpty(licence.RegisterNumber, "Numero de Registro não pode ser nulo ou vazio")
            .IsNotNullOrEmpty(licence.LicenceNumber, "Numero de Licença não pode ser nulo ou vazio");
        }
    }
}