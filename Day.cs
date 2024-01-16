using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitters
{
    public class Day
    {
        private DateTime date;
        private DayMeals meals;
        private List<UserActivity> activities;
        private UserInformation information;

        public DateTime Date { get => date; }

        public Day()
        {
            date = DateTime.Now;
        }

        public Day(UserInformation information)
        {
            this.information = information;
            date = DateTime.Now;
        }
    }
}
