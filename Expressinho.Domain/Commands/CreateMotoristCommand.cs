using Expressinho.Domain.Commands.Contracts;
using Expressinho.Domain.Entities;
using Expressinho.Domain.ValueObjects;
using Expressinho.Domain.ValueObjects.Contracts;
using Flunt.Validations;

namespace CreateMotoristCommand
{
    public class CreateMotoristCommand : Contract<CreateMotoristCommand>,ICommand
    {
        public CreateMotoristCommand(){}

        public CreateMotoristCommand(
            string name, 
            Email email, 
            string phone, 
            EGender gender, 
            byte[] password,
            byte[] salt, 
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
            BirthDate = birthdate;
            Licence = licence;
            LicenceCategory = licenceCategory;
        }
        public string? Name {get; private set;}

        public Email? Email {get; private set;}
        
        public string? Phone {get; private set;}

        public EGender Gender{get; private set;}
        
        public byte[]? Password{get; private set;}

        public byte[]? Salt{get; private set;}
        
        public DateTime BirthDate {get; private set;}

        public Licence? Licence{get; private set;}

        public ELicenceCategory LicenceCategory{get; private set;}

        public void Validate()
        {
            AddNotifications(
                Requires()
                .IsNotNullOrEmpty(Name,"nome não pode ser nulo ou vazio")
                .IsNotNullOrEmpty(Phone, "telefone não pode ser nulo ou vazio")
            );
        }
    }
}