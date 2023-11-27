using AdonetTask.Helpers;
using AdonetTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AdonetTask.Services
{
    internal static class UserServices
    {
        public static int Create(User data)
        {
            const int keySize = 64;
            const int iterations = 350000;
            string pas = data.Password;

            HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA512;
            
            byte[] salt = RandomNumberGenerator.GetBytes(keySize);
            var hash = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(data.Password),
                salt,
                iterations,
                hashAlgorithm,
                keySize);

            string query = $"INSERT INTO Users VALUES (N'{data.Name}', N'{data.Surame}', N'{hash})";
            return SqlHelpers.Exec(query);
        }
    }
}
