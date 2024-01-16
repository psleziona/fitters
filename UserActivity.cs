using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitters
{
    internal class UserActivity
    {
        private Activity activity;
        private int timeSpent;
        private double burnedCalories;

        public double BurnedCalories { get => burnedCalories; }

        public UserActivity(Activity activity, int timeSpent)
        {
            this.activity = activity;
            this.timeSpent = timeSpent;
            CountBurnedCalories();
        }

        private void CountBurnedCalories()
        {
            this.burnedCalories = (activity.CaloriesBurnPerHour * timeSpent) / 60;
        }
    }
}
