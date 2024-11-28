using Expressinho.Domain.Commands.Contracts;
using Expressinho.Domain.Entities;
using Expressinho.Domain.Security;
using Expressinho.Domain.ValueObjects;
using Flunt.Validations;

namespace Expressinho.Domain.Commands
{
    public class CreatePassagerCommand : Contract<CreatePassagerCommand>,ICommand
    {
        public CreatePassagerCommand
        (
            string name, 
            Email email, 
            string phone, 
            EGender gender, 
            byte[] password,
            byte[] salt,
            int iterations, 
            DateTime birthdate
        )
        {
            Name = name;
            Email = email;
            Phone = phone;
            Gender = gender;
            Password = password;
            Salt = salt;
            Iterations = iterations;
            BirthDate = birthdate;            
        }

        public string Name {get; private set;}
        public Email Email {get; private set;}
        public string Phone {get; private set;}
        public EGender Gender{get; private set;}
        public byte[] Password{get; private set;}
        public byte[] Salt{get; private set;}
        public int Iterations {get; private set;}
        public DateTime BirthDate {get; private set;}

        public void Validate()
        {
            AddNotifications(
                Requires()
                .IsNotNullOrEmpty(Name,"Não pode ser nulo ou vazio")
                .IsNotNullOrEmpty(Phone, "Não pode ser nulo ou vazio")
                .IsNotNull(Password, "Não pode ser nulo")
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