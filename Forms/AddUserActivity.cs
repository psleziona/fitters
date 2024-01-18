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
    public partial class AddUserActivity : Form
    {
        private DateTime date;
        RefreshDataGridView showActivities;
        public AddUserActivity(DateTime date, RefreshDataGridView showActivities)
        {
            InitializeComponent();
            this.date = date;
            this.showActivities = showActivities;
            FillDataGrid(Fitters.app.calorieTracker.ActivitiesService.Activities);

        }

        private void buttonAddUserActivity_Click(object sender, EventArgs e)
        {
            string activityName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Activity activity = Fitters.app.calorieTracker.ActivitiesService.Activities.Find(x => x.Name == activityName);
            int timeSpent = int.Parse(textBoxTimeSpent.Text);
            UserActivity userActivity = new UserActivity(activity, timeSpent);
            Fitters.app.calorieTracker.UserService.AddUserActivity(date, userActivity);
            showActivities.Invoke();
            this.Close();
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            string value = textBoxSearch.Text.ToLower();
            List<Activity> filtered = Fitters.app.calorieTracker.ActivitiesService.Activities
                .Where(a => a.Name.ToLower().StartsWith(value)).ToList();
            FillDataGrid(filtered);
            
        }

        private void FillDataGrid(List<Activity> activities)
        {
            dataGridView1.Rows.Clear();
            foreach (var a in activities)
            {
                dataGridView1.Rows.Add(a.Name, a.CaloriesBurnPerHour);
            }
        }
    }
}
