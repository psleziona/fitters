using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitters
{
    internal interface FileUtility
    {
        public static User ReadUserDateFromFile(string login)
        {
            return new User();
        }

        public static void WriteUserDateToFile(User user) { }
    }
}
