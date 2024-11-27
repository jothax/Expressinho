using Flunt.Validations;

namespace Expressinho.Domain.ValueObjects.Contracts
{
    public class CreateEmailContract : Contract<Email>
    {
        public CreateEmailContract(Email email)
        {
            Requires()
                .IsNotEmail(email.Address, "Email invalido");

        }
    }
}