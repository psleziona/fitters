using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitters
{
    public class Calendar
    {
        private List<Day> days;

        public List<Day> Days { get => days; }
        public Calendar() { }

        public Calendar(List<Day> days) { this.days = days; }

        public UserStatictics GetStatictics(DateTime start, DateTime end)
        {
            return new UserStatictics();
        }
    }
}
