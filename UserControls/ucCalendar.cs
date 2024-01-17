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

namespace Fitters.UserControls
{
    public partial class ucCalendar : UserControl
    {
        private int month;
        private int year;
        public ucCalendar()
        {
            InitializeComponent();
            InitializeData();
            DisplayDays();
        }

        private void InitializeData()
        {
            year = DateTime.Now.Year;
            month = DateTime.Now.Month;
            comboBoxYears.Items.AddRange(new object[] { 2023, 2024, 2025 });
            comboBoxYears.SelectedItem = DateTime.Now.Year;
            for (int i = 1; i < 13; i++)
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

            for (int i = 1; i < dayOfTheWeek; i++)
            {
                CalendarDayBlank day = new CalendarDayBlank();
                panelCalendar.Controls.Add(day);
            }

            for (int i = 1; i <= days; i++)
            {
                bool active = new DateTime(year, month, i) <= DateTime.Now;
                CalendarDay day = new CalendarDay(active, new DateTime(year, month, i));
                day.SetDayNumber(i);
                panelCalendar.Controls.Add(day);
            }
        }

        private void buttonPreviousMonth_Click(object sender, EventArgs e)
        {
            month--;
            if (month == 0)
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
            if (month == 13)
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
    }
}
