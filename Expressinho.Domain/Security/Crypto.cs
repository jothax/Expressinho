using System.Security.Cryptography;
using System.Text;

namespace Expressinho.Domain.Security
{
    //this base classe comes from auzne
    //https://github.com/auzne/CatADog/blob/master/CatADog.Domain/Security/CryptoUtils.cs
    
    public static class Crypto
    {
        private const int ByteQuantity = 64;
        public const int DefaultIterations = 10000000; // 10 million

        public static byte[] HashPassword(string password, byte[] salt, int iterations = DefaultIterations)
        {
            return HashPassword(Encoding.Unicode.GetBytes(password), salt, iterations);
        }

        public static byte[] HashPassword(byte[] password, byte[] salt, int iterations = DefaultIterations)
        {
            using var rfc2898 = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA512);
            return rfc2898.GetBytes(ByteQuantity);
        }

        public static byte[] GenerateSalt()
        {
            return RandomNumberGenerator.GetBytes(ByteQuantity);
        }
    }
}
