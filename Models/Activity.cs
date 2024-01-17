using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitters
{
    public class Activity
    {
        private string name;
        private int caloriesBurnPerHour;

        public string Name { get => name; }
        public int CaloriesBurnPerHour { get => caloriesBurnPerHour; }

        public Activity(string name, int caloriesBurnPerHour)
        {
            this.name = name;
            this.caloriesBurnPerHour = caloriesBurnPerHour;
        }
    }
}
