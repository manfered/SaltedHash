using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaltedHash
{
    class Program
    {
        static void Main(string[] args)
        {
            const string password = "!@#QWEASDZXC";
            byte[] salt = SaltedHash.GenerateSalt();

            Console.WriteLine("Hash Password With Salt");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            Console.WriteLine($"Password : {password}");
            Console.WriteLine($"sale : {Convert.ToBase64String(salt)}");
            Console.WriteLine();

            var hashedPassword = SaltedHash.HashPasswordWithSalt(
                                 Encoding.UTF8.GetBytes(password),
                                 salt);

            Console.WriteLine();
            Console.WriteLine($"Hashed Password = {Convert.ToBase64String(hashedPassword)}");
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
