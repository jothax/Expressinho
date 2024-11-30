using Expressinho.Domain.Commands.Contracts;
using Expressinho.Domain.Security;
using Expressinho.Domain.ValueObjects;
using Flunt.Validations;

namespace Expressinho.Domain.Commands
{
    public class CreatePassagerCommand : Contract<CreatePassagerCommand>, ICommand, IEncrypt
    {
        public CreatePassagerCommand
        (
            string name, 
            Email email, 
            byte[] password,
            byte[] salt,
            int iterations, 
            DateTime birthdate
        )
        {
            Name = name;
            Email = email;
            Password = password;
            Salt = salt;
            Iterations = iterations;
            BirthDate = birthdate;            
        }

        public string Name {get; set;}
        public Email Email {get; set;}
        public byte[] Password{get; set;}
        public byte[] Salt{get; set;}
        public int Iterations {get; set;}
        public DateTime BirthDate {get; set;}

        public void Validate()
        {
            AddNotifications(
                Requires()
                .IsLowerThan(Name, 5,"Tem que ser maior que 3")
                .IsLowerThan(BirthDate, DateTime.Now.AddYears(-18), "Precisa ser maior de idade")
                .Join(Email)
            );
        }

        public void CryptPassword()
        {
            Salt = Crypto.GenerateSalt();
            Iterations = Crypto.DefaultIterations;
            Password = Crypto.HashPassword(Password, Salt, Iterations);
        }
    }
}