using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitters
{
    public class User
    {
        private string login;
        private string password;
        private UserGender gender;
        private Calendar calendar;
        private double caloriesDemand;

        public string Login { get => login; }
        public string Password { get => password; set => password = value; }
        public Calendar Calendar { get => calendar; }

        public User(string login, string password, UserInformation userInformation)
        {
            this.login = login;
            this.password = password;


            List<Day> days = new List<Day>()
            {
                new Day(userInformation)
            };
            calendar = new Calendar(days);
        }
    }
}
