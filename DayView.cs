using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitters
{
    public partial class DayView : Form
    {
        Day day;
        public DayView(DateTime date)
        {
            InitializeComponent();
            label26.Text = date.ToString();
            day = Fitters.app.User.GetUserDay(date);
        }

        private void ShowBreakfast()
        {
            if(day.Meals.Breakfast != null)
            {
                foreach(var p in day.Meals.Breakfast.Products)
                {
                    if(p is ProductBulk)
                }
            }
        }

        private void ShowBrunch()
        {
            if(day.Meals.Brunch != null)
            {

            }
        }

        private void ShowAfternoonTea()
        {
            if(day.Meals.AfternoonTea != null)
            {

            }
        }

        private void ShowDinner()
        {
            if(day.Meals.Dinner != null)
            {

            }
        }

        private void ShowLunch()
        {
            if(day.Meals.Lunch != null)
            {

            }
        }

        private void ShowActivities()
        {

        }
    }
}
