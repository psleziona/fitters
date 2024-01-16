using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitters
{
    internal class FileUtility
    {
        public static User? ReadUserDateFromFile(string login)
        {
            try
            {
                using StreamReader sr = new StreamReader("data/" + login);
                return JsonConvert.DeserializeObject<User>(sr.ReadToEnd());
            } catch(FileNotFoundException ex) { }
            return null;
        }

        public static void WriteUserDateToFile(User user) {
            using StreamWriter sr = new StreamWriter("data/" + user.Login);
            sr.Write(JsonConvert.SerializeObject(user));
        }
    }
}
