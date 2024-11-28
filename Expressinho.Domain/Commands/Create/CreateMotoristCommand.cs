using Expressinho.Domain.Commands.Contracts;
using Expressinho.Domain.Entities;
using Expressinho.Domain.Security;
using Expressinho.Domain.ValueObjects;
using Flunt.Validations;

namespace Expressinho.Domain.Commands
{
    public class CreateMotoristCommand : Contract<CreateMotoristCommand>,ICommand
    {
        public CreateMotoristCommand(
            string name, 
            Email email, 
            string phone, 
            EGender gender, 
            byte[] password,
            byte[] salt,
            int iterations, 
            DateTime birthdate,
            Licence licence,
            ELicenceCategory licenceCategory
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
            Licence = licence;
            LicenceCategory = licenceCategory;
        }
        public string Name {get; private set;}
        public Email Email {get; private set;}      
        public string Phone {get; private set;}
        public EGender Gender{get; private set;}     
        public byte[] Password{get; private set;}
        public byte[] Salt{get; private set;}
        public int Iterations {get; private set;}       
        public DateTime BirthDate {get; private set;}
        public Licence Licence{get; private set;}
        public ELicenceCategory LicenceCategory{get; private set;}
        
        public void Validate()
        {
            AddNotifications(
                Requires()
                .IsNotNullOrEmpty(Name,"Não pode ser nulo ou vazio")
                .IsNotNullOrEmpty(Phone, "Não pode ser nulo ou vazio")
                .Join(Email, Licence)
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