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
    public partial class Fitters : Form
    {
        public static Fitters app;
        private User activeUser;
        public List<Product> products;
        public List<Activity> activities;
        private int month;
        private int year;

        public User User { get { return activeUser; } }
        public Fitters()
        {
            InitializeComponent();
            app = this;
            year = DateTime.Now.Year;
            month = DateTime.Now.Month;
            products = FileUtility.ReadDataFromFile<List<Product>>("products") ?? new List<Product>();
            activities = FileUtility.ReadDataFromFile<List<Activity>>("activities") ?? new List<Activity>();
            comboBoxProductUnit.Items.AddRange(new object[] { ProductUnit.MILLILITRE, ProductUnit.GRAM });
            foreach(var p in products)
            {
                dataGridViewProducts.Rows.Add(p.Name, p.Proteins, p.Carbons, p.Fats, "1", p.Calories);
            }

            foreach (var a in activities)
                dataGridViewActivities.Rows.Add("d", a.CaloriesBurnPerHour);
        }

        public void SetActiveUser(User user)
        {
            activeUser = user;
            DisplayDays();
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            int index = tabControl1.SelectedIndex;
        }

        private void Fitters_Load(object sender, EventArgs e)
        {
            Welcome form1 = new Welcome();
            form1.ShowDialog();
            this.Hide();

            comboBoxYears.Items.AddRange(new object[] { 2023, 2024, 2025 });
            comboBoxYears.SelectedItem = DateTime.Now.Year;
            for(int i = 1;i <13;i++)
                comboBoxMonths.Items.Add(i);
            comboBoxMonths.SelectedItem = DateTime.Now.Month;
        }

        private void DisplayDays()
        {
            panelCalendar.Controls.Clear();
            labelDate.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(month) + " " + year;
            DateTime startOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for(int i = 1; i< dayOfTheWeek; i++)
            {
                CalendarDayBlank day = new CalendarDayBlank();
                panelCalendar.Controls.Add(day);
            }

            for (int i = 1; i <= days; i++)
            {
                CalendarDay day;
                bool active = new DateTime(year, month, i) <= DateTime.Now;
                try
                {
                    Day d = activeUser.Calendar.Days.Where(day => day.Date.Equals(new DateTime(year, month, i))).First();
                    day = new CalendarDay(active, d, new DateTime(year, month, i));
                }
                catch (InvalidOperationException e) 
                {
                    day = new CalendarDay(active, new DateTime(year, month, i));
                }

                day.Days(i);
                panelCalendar.Controls.Add(day);
            }
        }

        private void buttonPreviousMonth_Click(object sender, EventArgs e)
        {
            month--;
            if(month == 0)
            {
                month = 12;
                year--;
            }
            DisplayDays();
            SetCurrentDateOnControls();
        }

        private void buttonNextMonth_Click(object sender, EventArgs e)
        {
            month++;
            if(month == 13)
            {
                month = 1;
                year++;
            }
            DisplayDays();
            SetCurrentDateOnControls();
        }

        private void buttonShowCalendar_Click(object sender, EventArgs e)
        {
            year = (int)comboBoxYears.SelectedItem;
            month = (int)comboBoxMonths.SelectedItem;
            DisplayDays();
        }

        private void SetCurrentDateOnControls()
        {
            comboBoxYears.SelectedItem = year;
            comboBoxMonths.SelectedItem = month;
        }

        private void buttonAddProductToBase_Click(object sender, EventArgs e)
        {
            string name = textBoxProductName.Text;
            double proteins = double.Parse(textBoxProductProtein.Text);
            double fats = double.Parse(textBoxProductFat.Text);
            double carbons = double.Parse(textBoxProductCarbon.Text);
            bool isCountable = checkBoxIsProductCountable.Checked;

            if(isCountable)
            {
                ProductIndividual p = new ProductIndividual(name, proteins, carbons, fats);
                products.Add(p);
            } 
            else
            {
                int capacity = int.Parse(textBoxProductAmount.Text);
                ProductUnit unit = (ProductUnit)comboBoxProductUnit.SelectedItem;
                ProductBulk p = new ProductBulk(name, proteins, carbons, fats, capacity, unit);
                products.Add(p);
            }
            FileUtility.WriteDateToFile(products, "/products");
            

        }

        private void checkBoxIsProductCountable_CheckedChanged(object sender, EventArgs e)
        {
            textBoxProductAmount.Enabled = !checkBoxIsProductCountable.Checked;
            comboBoxProductUnit.Enabled = !checkBoxIsProductCountable.Checked;
        }

        private void buttonAddActivityToBase_Click(object sender, EventArgs e)
        {
            string name = textBoxActivityName.Text;
            int caloriesBurned = int.Parse(textBoxActivityBurnedCalories.Text);
            Activity activity = new Activity(name, caloriesBurned);
            activities.Add(activity);
            FileUtility.WriteDateToFile(activities, "/activities");
        }
    }
}
