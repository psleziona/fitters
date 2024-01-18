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

        public User(string login, string password, UserGender gender, Calendar calendar)
        {
            this.login = login;
            this.password = password;
            this.gender = gender;
            this.calendar = calendar;
        }

        public Day GetUserDay(DateTime date)
        {
            try
            {
                return calendar.Days.Where(d => d.Date == date).First();
            } 
            catch(InvalidOperationException e)
            {
                Day day = new Day(date);
                calendar.Days.Add(day);
                return day;
            }
        }
    }
}
