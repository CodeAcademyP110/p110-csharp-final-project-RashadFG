using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ColemanFitnessClub.Utilities
{
    class Hash
    {
        public static string GetHash(string password)
        {
            byte[] bytes = new ASCIIEncoding().GetBytes(password);
            byte[] encrytedBytes = new SHA256Managed().ComputeHash(bytes);
            return new ASCIIEncoding().GetString(encrytedBytes);
        }

        public static bool CheckHashCode(string hashcode, string password)
        {
            return hashcode == GetHash(password);
        }

        public enum Roles : byte
        {
            Admin = 1,
            Employee = 2,
        }
    }
}
