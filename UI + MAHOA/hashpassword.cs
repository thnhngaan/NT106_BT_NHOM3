using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace BAITAP_NT106
{
    internal class hashpassword
    {
        public static string ToSHA256(string input)
        {
            using var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

            var sb = new StringBuilder();   
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }
            return sb.ToString();
        }
        public static bool VerifyPassword(string storedHash, string password)
        {
            string inputHash = ToSHA256(password);
            return storedHash == inputHash;
        }
    }
}
