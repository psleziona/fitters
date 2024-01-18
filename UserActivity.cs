using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitters
{
    public class UserActivity
    {
        private Activity activity;
        private int timeSpent;
        private double burnedCalories;

        public int TimeSpent { get => timeSpent; }
        public double BurnedCalories { get => burnedCalories; }
        public Activity Activity { get => activity; }

        public UserActivity(Activity activity, int timeSpent)
        {
            this.activity = activity;
            this.timeSpent = timeSpent;
            CountBurnedCalories();
        }

        public string GetActivityName()
        {
            return activity.Name;
        }

        private void CountBurnedCalories()
        {
            this.burnedCalories = (activity.CaloriesBurnPerHour * timeSpent) / 60;
        }
    }
}
