using Fitters.Models;
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
            day = Fitters.app.calorieTracker.UserService.GetDayInformation(date);
            ShowBreakfast();
            ShowBrunch();
            ShowLunch();
            ShowAfternoonTea();
            ShowDinner();
            ShowActivities();
        }

        private void ShowBreakfast()
        {
            if(day.Meals.Breakfast != null)
            {
                foreach(var p in day.Meals.Breakfast.Products)
                {
                    dataGridView1.Rows.Add(p.Product.Name, p.Quantity, p.GetCalories());
                }
            }
        }

        private void ShowBrunch()
        {
            if(day.Meals.Brunch != null)
            {
                foreach (var p in day.Meals.Brunch.Products)
                {
                    dataGridView2.Rows.Add(p.Product.Name, p.Quantity, p.GetCalories());
                }
            }
        }

        private void ShowAfternoonTea()
        {
            if(day.Meals.AfternoonTea != null)
            {
                foreach (var p in day.Meals.AfternoonTea.Products)
                {
                    dataGridView4.Rows.Add(p.Product.Name, p.Quantity, p.GetCalories());
                }
            }
        }

        private void ShowDinner()
        {
            if(day.Meals.Dinner != null)
            {
                foreach (var p in day.Meals.Dinner.Products)
                {
                    dataGridView5.Rows.Add(p.Product.Name, p.Quantity, p.GetCalories());
                }
            }
        }

        private void ShowLunch()
        {
            if(day.Meals.Lunch != null)
            {
                foreach (var p in day.Meals.Lunch.Products)
                {
                    dataGridView3.Rows.Add(p.Product.Name, p.Quantity, p.GetCalories());
                }
            }
        }

        private void ShowActivities()
        {
            
        }

        private void buttonAddBreakfast_Click(object sender, EventArgs e)
        {
            AddProductToMeal f = new AddProductToMeal(day.Date, typeof(Breakfast));
            f.ShowDialog();
        }

        private void buttonAddBrunch_Click(object sender, EventArgs e)
        {
            AddProductToMeal f = new AddProductToMeal(day.Date, typeof(Brunch));
            f.ShowDialog();
        }

        private void buttonAddLunch_Click(object sender, EventArgs e)
        {
            AddProductToMeal f = new AddProductToMeal(day.Date, typeof(Lunch));
            f.ShowDialog();
        }

        private void buttonAddAfternoonTea_Click(object sender, EventArgs e)
        {
            AddProductToMeal f = new AddProductToMeal(day.Date, typeof(AfternoonTea));
            f.ShowDialog();
        }

        private void buttonAddDinner_Click(object sender, EventArgs e)
        {
            AddProductToMeal f = new AddProductToMeal(day.Date, typeof(Dinner));
            f.ShowDialog();
        }
    }
}
