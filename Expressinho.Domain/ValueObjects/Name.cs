using Expressinho.Domain.ValueObjects.Contracts;

namespace Expressinho.Domain.ValueObjects
{
    public class Name : ValueObjects
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new CreateNameContract(this));
        }

        public string FirstName {get; private set;}
        public string LastName {get; private set;}
    }
}