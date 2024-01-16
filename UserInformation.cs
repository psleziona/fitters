using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitters
{
    public class UserInformation
    {
        private double weight;
        private int height;
        private int age;
        private ActivityLevel activityLevel;

        public UserInformation(double weight, int height, int age, ActivityLevel activityLevel)
        {
            this.weight = weight;
            this.height = height;
            this.age = age;
            this.activityLevel = activityLevel;
        }

        public double GetCaloriesDemand(UserGender gender)
        {
            double baseBMR = 10 * this.weight + 6.25 * this.height - 5 * age;
            baseBMR = gender == UserGender.MALE ? baseBMR + 5 : baseBMR - 161;
            double activityFactor = (double)((int)activityLevel) / 10;
            return baseBMR * activityFactor;
        }
    }
}
