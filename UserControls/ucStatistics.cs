using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Fitters.UserControls
{
    public partial class ucStatistics : UserControl
    {
        private List<Day> days;
        private double eatenProteins;
        private double eatenCarbons;
        private double eatenFats;
        private double eatenCalories;
        private double burnedCalories;
        private double caloriesDemand;
        private double balance;
        public ucStatistics()
        {
            InitializeComponent();
            DateTime start = dateTimePicker1.Value.Date;
            DateTime end = dateTimePicker2.Value.Date;
            GenerateStatictics(start, end);      
        }

        private void GenerateStatictics(DateTime start, DateTime end)
        {
            days = Fitters.app.calorieTracker.UserService.GetDayList(start, end);
            eatenProteins = days.Aggregate(0.0, (total, day) => total + day.GetEatenProteins());
            eatenCarbons = days.Aggregate(0.0, (total, day) => total + day.GetEatenCarbons());
            eatenFats = days.Aggregate(0.0, (total, day) => total + day.GetEatenFats());
            eatenCalories = days.Aggregate(0.0, (total, day) => total + day.GetEatenCalories());
            burnedCalories = days.Aggregate(0.0, (total, day) => total + day.GetBurnedCalories());
            balance = eatenCalories - burnedCalories;
            ShowStatictics();
        }

        private void ShowStatictics()
        {
            labelEatenProteins.Text = eatenProteins.ToString() + " gram";
            labelEatenFats.Text = eatenFats.ToString() + " gram";
            labelEatenCarbs.Text = eatenCarbons.ToString() + " gram";
            labelEatenCalories.Text = eatenCalories.ToString() + " kcal";
            labelBurnedCalories.Text = burnedCalories.ToString() + " kcal";
            labelEnergyNeed.Text = "";//todo
            labelBilans.Text = balance.ToString() + " kcal";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DateTime start = dateTimePicker1.Value.Date;
            DateTime end = dateTimePicker2.Value.Date;
            GenerateStatictics(start, end);
        }

        private void x ()
        {
            Series series = new Series("dd");
            series.ChartType = SeriesChartType.Pie;
            series.Points.Add(new DataPoint(1, 2));
            series.Points.Add(new DataPoint(4,5));

        }
    }
}
