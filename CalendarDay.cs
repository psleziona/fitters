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
    public partial class CalendarDay : UserControl
    {
        bool active;
        public CalendarDay(bool active)
        {
            InitializeComponent();
            this.active = active;
        }

        private void CalendarDay_Load(object sender, EventArgs e)
        {
            if (!active)
                this.BackColor = Color.FromArgb(237, 239, 242);
        }

        public void Days(int numDay)
        {
            label1.Text = numDay + "";
        }
    }
}
