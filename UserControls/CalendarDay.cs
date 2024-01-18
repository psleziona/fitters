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
    public delegate void RefreshControl();
    public partial class CalendarDay : UserControl
    {
        private bool active;
        private Day day;
        private DateTime date;
        public CalendarDay(bool active, DateTime date)
        {
            InitializeComponent();
            this.active = active;
            this.date = date;
            day = Fitters.app.calorieTracker.UserService.GetDayInformation(date);
            SetDayInformation();
        }

        private void CalendarDay_Load(object sender, EventArgs e)
        {
            if (!active)
                this.BackColor = Color.FromArgb(237, 239, 242);
        }

        public void SetDayNumber(int numDay)
        {
            label1.Text = numDay + "";
        }

        private void CalendarDay_Click(object sender, EventArgs e)
        {
            if (!active) return;
            DayView dayView = new DayView(date, new RefreshControl(SetDayInformation));
            dayView.Show();
        }

        private void SetDayInformation()
        {
            label7.Text = day.GetEatenMealsNumber().ToString();
            label6.Text = day.GetEatenCalories().ToString() + " kcal";
            label5.Text = day.GetBurnedCalories().ToString() + " kcal";
        }
    }
}
