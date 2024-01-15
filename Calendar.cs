using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitters
{
    internal class Calendar
    {
        private List<Day> days;
        public Calendar() { }

        public Calendar(List<Day> days) { this.days = days; }

        public UserStatictics GetStatictics(DateTime start, DateTime end)
        {
            return new UserStatictics();
        }
    }
}
