﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitters
{
    internal interface ICalorieCounter
    {
        public void CountCalories();
        public double GetCalories();
    }
}
