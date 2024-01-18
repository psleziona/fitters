using Fitters.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitters
{
    public delegate void RefreshDataGridView();
    public partial class DayView : Form
    {
        Day day;
        RefreshControl updateInformation;
        public DayView(DateTime date, RefreshControl updateInformation)
        {
            InitializeComponent();
            label26.Text = date.Day + " " + DateTimeFormatInfo.CurrentInfo.GetMonthName(date.Month) + " " + date.Year;
            day = Fitters.app.calorieTracker.UserService.GetDayInformation(date);
            this.updateInformation= updateInformation;
            ShowBreakfast();
            ShowBrunch();
            ShowLunch();
            ShowAfternoonTea();
            ShowDinner();
            ShowActivities();
        }

        private void ShowBreakfast()
        {
            dataGridView1.Rows.Clear();
            if(day.Meals.Breakfast != null)
            {
                foreach(var p in day.Meals.Breakfast.Products)
                {
                    dataGridView1.Rows.Add(p.Product.Name, p.Quantity, p.GetCalories());
                }
                labelBreakfastProteins.Text = day.Meals.Breakfast.GetMealProteins().ToString() + " gram";
                labelBreakfastFats.Text = day.Meals.Breakfast.GetMealFats().ToString() + " gram";
                labelBreakfastCarbs.Text = day.Meals.Breakfast.GetMealCarbons().ToString() + " gram";
                labelBreakfastCalories.Text = day.Meals.Breakfast.GetCalories().ToString() + " kcal";
                updateInformation.Invoke();
                UpdateBalance();
            }
        }

        private void ShowBrunch()
        {
            dataGridView2.Rows.Clear();
            if(day.Meals.Brunch != null)
            {
                foreach (var p in day.Meals.Brunch.Products)
                {
                    dataGridView2.Rows.Add(p.Product.Name, p.Quantity, p.GetCalories());
                }
                labelBrunchProteins.Text = day.Meals.Brunch.GetMealProteins().ToString() + " gram";
                labelBrunchFats.Text = day.Meals.Brunch.GetMealFats().ToString() + " gram";
                labelBrunchCarbs.Text = day.Meals.Brunch.GetMealCarbons().ToString() + " gram";
                labelBrunchCalories.Text = day.Meals.Brunch.GetCalories().ToString() + " kcal";
                updateInformation.Invoke();
                UpdateBalance();
            }
        }

        private void ShowLunch()
        {
            dataGridView3.Rows.Clear();
            if (day.Meals.Lunch != null)
            {
                foreach (var p in day.Meals.Lunch.Products)
                {
                    dataGridView3.Rows.Add(p.Product.Name, p.Quantity, p.GetCalories());
                }
                labelLunchProteins.Text = day.Meals.Lunch.GetMealProteins().ToString() + " gram";
                labelLunchFats.Text = day.Meals.Lunch.GetMealFats().ToString() + " gram";
                labelLunchCarbs.Text = day.Meals.Lunch.GetMealCarbons().ToString() + " gram";
                labelLunchCalories.Text = day.Meals.Lunch.GetCalories().ToString() + " kcal";
                updateInformation.Invoke();
                UpdateBalance();
            }
        }

        private void ShowAfternoonTea()
        {
            dataGridView4.Rows.Clear();
            if(day.Meals.AfternoonTea != null)
            {
                foreach (var p in day.Meals.AfternoonTea.Products)
                {
                    dataGridView4.Rows.Add(p.Product.Name, p.Quantity, p.GetCalories());
                }
                labelAfternoonTeaProteins.Text = day.Meals.AfternoonTea.GetMealProteins().ToString() + " gram";
                labelAfternoonTeaFats.Text = day.Meals.AfternoonTea.GetMealFats().ToString() + " gram";
                labelAfternoonTeaCarbs.Text = day.Meals.AfternoonTea.GetMealCarbons().ToString() + " gram";
                labelAfternoonTeaCalories.Text = day.Meals.AfternoonTea.GetCalories().ToString() + " kcal";
                updateInformation.Invoke();
                UpdateBalance();
            }
        }

        private void ShowDinner()
        {
            dataGridView5.Rows.Clear();
            if(day.Meals.Dinner != null)
            {
                foreach (var p in day.Meals.Dinner.Products)
                {
                    dataGridView5.Rows.Add(p.Product.Name, p.Quantity, p.GetCalories());
                }
                labelDinnerProteins.Text = day.Meals.Dinner.GetMealProteins().ToString() + " gram";
                labelDinnerFats.Text = day.Meals.Dinner.GetMealFats().ToString() + " gram";
                labelDinnerCarbs.Text = day.Meals.Dinner.GetMealCarbons().ToString() + " gram";
                labelDinnerCalories.Text = day.Meals.Dinner.GetCalories().ToString() + " kcal";
                updateInformation.Invoke();
                UpdateBalance();
            }
        }

        private void ShowActivities()
        {
            dataGridView6.Rows.Clear();
            if(day.Activities != null)
            {
                foreach(var a in day.Activities)
                {
                    dataGridView6.Rows.Add(a.GetActivityName(), a.TimeSpent, a.BurnedCalories);
                }
                labelCaloriesBurned.Text = day.GetBurnedCalories().ToString() + " kcal";
                updateInformation.Invoke();
                UpdateBalance();
            }
        }

        private void UpdateBalance()
        {
            labelBalance.Text = day.GetDayCaloriesBalance().ToString() + " kcal";
            labelTotalEaten.Text = day.GetEatenCalories().ToString() + " kcal";
            labelBurnedTotal.Text = day.GetBurnedCalories().ToString() + " kcal";
        }

        private void buttonAddBreakfast_Click(object sender, EventArgs e)
        {
            AddProductToMeal f = new AddProductToMeal(day.Date, typeof(Breakfast), new RefreshDataGridView(ShowBreakfast));
            f.ShowDialog();
        }

        private void buttonAddBrunch_Click(object sender, EventArgs e)
        {
            AddProductToMeal f = new AddProductToMeal(day.Date, typeof(Brunch), new RefreshDataGridView(ShowBrunch));
            f.ShowDialog();
        }

        private void buttonAddLunch_Click(object sender, EventArgs e)
        {
            AddProductToMeal f = new AddProductToMeal(day.Date, typeof(Lunch), new RefreshDataGridView(ShowLunch));
            f.ShowDialog();
        }

        private void buttonAddAfternoonTea_Click(object sender, EventArgs e)
        {
            AddProductToMeal f = new AddProductToMeal(day.Date, typeof(AfternoonTea), new RefreshDataGridView(ShowAfternoonTea));
            f.ShowDialog();
        }

        private void buttonAddDinner_Click(object sender, EventArgs e)
        {
            AddProductToMeal f = new AddProductToMeal(day.Date, typeof(Dinner), new RefreshDataGridView(ShowDinner));
            f.ShowDialog();
        }

        private void buttonAddActivity_Click(object sender, EventArgs e)
        {
            AddUserActivity f = new AddUserActivity(day.Date, new RefreshDataGridView(ShowActivities));
            f.ShowDialog();
        }
    }
}
