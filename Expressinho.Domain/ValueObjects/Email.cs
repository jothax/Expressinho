using Expressinho.Domain.ValueObjects.Contracts;

namespace Expressinho.Domain.ValueObjects
{
    public class Email : ValueObjects
    {
        public Email(string address)
        {
            Address = address;
            AddNotifications(new CreateEmailContract(this));
        }
        public string Address {get; private set;}
    }
}