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
                    dataGridView1.Rows.Add(p.Product.Name, p.Quantity, p.CountCalories());
                }
            }
        }

        private void ShowBrunch()
        {
            if(day.Meals.Brunch != null)
            {
                foreach (var p in day.Meals.Breakfast.Products)
                {
                    dataGridView2.Rows.Add(p.Product.Name, p.Quantity, p.CountCalories());
                }
            }
        }

        private void ShowAfternoonTea()
        {
            if(day.Meals.AfternoonTea != null)
            {
                foreach (var p in day.Meals.Breakfast.Products)
                {
                    dataGridView4.Rows.Add(p.Product.Name, p.Quantity, p.CountCalories());
                }
            }
        }

        private void ShowDinner()
        {
            if(day.Meals.Dinner != null)
            {
                foreach (var p in day.Meals.Breakfast.Products)
                {
                    dataGridView5.Rows.Add(p.Product.Name, p.Quantity, p.CountCalories());
                }
            }
        }

        private void ShowLunch()
        {
            if(day.Meals.Lunch != null)
            {
                foreach (var p in day.Meals.Breakfast.Products)
                {
                    dataGridView3.Rows.Add(p.Product.Name, p.Quantity, p.CountCalories());
                }
            }
        }

        private void ShowActivities()
        {
            
        }

        private void buttonAddBreakfast_Click(object sender, EventArgs e)
        {
            AddProductToMeal f = new AddProductToMeal(day.Date, day.Meals.Breakfast);
            f.ShowDialog();
        }

        private void buttonAddBrunch_Click(object sender, EventArgs e)
        {
            AddProductToMeal f = new AddProductToMeal(day.Date, day.Meals.Brunch);
            f.ShowDialog();
        }

        private void buttonAddLunch_Click(object sender, EventArgs e)
        {
            AddProductToMeal f = new AddProductToMeal(day.Date, day.Meals.Lunch);
            f.ShowDialog();
        }

        private void buttonAddAfternoonTea_Click(object sender, EventArgs e)
        {
            AddProductToMeal f = new AddProductToMeal(day.Date, day.Meals.AfternoonTea);
            f.ShowDialog();
        }

        private void buttonAddDinner_Click(object sender, EventArgs e)
        {
            AddProductToMeal f = new AddProductToMeal(day.Date, day.Meals.Dinner);
            f.ShowDialog();
        }
    }
}
