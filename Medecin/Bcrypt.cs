using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeStionB.Medecin
{
    internal class Bcrypt
    {
        public string Encryption (string pswd)
        {
            string hash = BCrypt.Net.BCrypt.EnhancedHashPassword(pswd,13);
            return hash;
        }
        public bool Descryption(string pswd, string hash)
        {
            bool result = BCrypt.Net.BCrypt.EnhancedVerify(pswd, hash);
            return result;
        }
    }
}
