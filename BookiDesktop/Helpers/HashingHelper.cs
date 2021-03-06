using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BookiDesktop.Helpers {
    public static class HashingHelper {

        private const string salt = "p9afXynoO3UNjuEAQmTA";

        public static string GenerateHash(string input) {
            byte[] bytes = Encoding.UTF8.GetBytes(input + salt);
            SHA256Managed sHA256ManagedString = new SHA256Managed();
            byte[] hash = sHA256ManagedString.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        public static bool AreEqual(string plainTextInput, string hashedInput) {
            string newHashedPin = GenerateHash(plainTextInput);
            return newHashedPin.Equals(hashedInput);
        }

        public static string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
