using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Fitters
{
    internal class UserAuth
    {
        public static User? AuthenticateUser(string login, string password)
        {
            User? user = FileUtility.ReadDataFromFile<User>("users/" + login);
            if(user != null)
            {
                if(IsDataValid(password, user.Password))
                    return user;
            }
            return null;
        }

        public static bool AddUser(User user)
        {
            user.Password = GetEncodedPassword(user.Password);
            FileUtility.WriteDateToFile(user, "users/" + user.Login);
            return true;
        }

        private static bool IsDataValid(string password, string savedPassword)
        {
            return string.Equals(GetEncodedPassword(password), savedPassword);
        }

        private static string GetEncodedPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder stringBuilder = new StringBuilder();
                foreach (byte b in hashedBytes)
                {
                    stringBuilder.Append(b.ToString("x2"));
                }

                return stringBuilder.ToString();
            }
        }
    }
}
