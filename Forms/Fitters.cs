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
using Fitters.Models;
using Fitters.UserControls;

namespace Fitters
{
    public partial class Fitters : Form
    {
        public static Fitters app;
        public CalorieTracker calorieTracker;
        public Fitters()
        {
            InitializeComponent();
            app = this;
            calorieTracker = new CalorieTracker();
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

            ucCalendar ucCalendar = new ucCalendar();
            tabPageCalendar.Controls.Add(ucCalendar);
            ucCalendar.Dock = DockStyle.Fill;

            ucProducts ucProducts = new ucProducts();
            tabPageProducts.Controls.Add(ucProducts);
            ucProducts.Dock = DockStyle.Fill;

            ucActivities ucActivities = new ucActivities();
            tabPageActivities.Controls.Add(ucActivities);
            ucActivities.Dock = DockStyle.Fill;

            ucStatistics ucStatistics = new ucStatistics();
            tabPageStatictics.Controls.Add(ucStatistics);
            ucStatistics.Dock = DockStyle.Fill;

            ucUserPanel ucUserPanel = new ucUserPanel();
            tabPageUser.Controls.Add(ucUserPanel);
            ucUserPanel.Dock = DockStyle.Fill;
        }
    }
}
