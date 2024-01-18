using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitters.UserControls
{
    public partial class ucActivities : UserControl
    {
        public ucActivities()
        {
            InitializeComponent();
            foreach (Activity a in Fitters.app.calorieTracker.ActivitiesService.Activities)
                dataGridViewActivities.Rows.Add(a.Name, a.CaloriesBurnPerHour);
        }

        private void buttonAddActivityToBase_Click(object sender, EventArgs e)
        {
            string name = textBoxActivityName.Text;
            int caloriesBurned = int.Parse(textBoxActivityBurnedCalories.Text);
            Activity activity = new Activity(name, caloriesBurned);
            Fitters.app.calorieTracker.ActivitiesService.AddActivity(activity);
            dataGridViewActivities.Rows.Add(activity.Name, activity.CaloriesBurnPerHour);
        }

    }
}
