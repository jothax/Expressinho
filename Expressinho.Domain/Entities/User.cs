using Expressinho.Domain.ValueObjects;

namespace Expressinho.Domain.Entities
{
    public class User : Entity
    {
        private IList<decimal> _rating;
        public User(
        Name name, 
        Email email, 
        string phone, 
        EGender gender, 
        byte[] password,
        byte[] salt, 
        DateTime birthdate
        ): base()
        {
            Name = name;
            Email = email;
            Phone = phone;
            Gender = gender;
            Password = password;
            Salt = salt;
            BirthDate = birthdate;
            _rating = new List<decimal>();
            AverageRating = _rating.Average();
        }
        public Name Name {get; private set;}

        public Email Email {get; private set;}
        
        public string Phone {get; private set;}
        
        public decimal AverageRating{get; private set;}

        public EGender Gender{get; private set;}
        
        public byte[] Password{get; private set;}

        public byte[] Salt{get; private set;}
        
        public DateTime BirthDate {get; private set;}

        public void AddRating(decimal value)
        {
            _rating.Add(value);
        }

        public void RemoveFirstRating()
        {
            _rating.Remove(_rating.FirstOrDefault());
        } 
    }
}