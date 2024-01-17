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
    public partial class LoginForm : Form
    {
        Welcome parent;
        public LoginForm(Welcome parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            User? loggedUser = UserAuth.AuthenticateUser(login, password);
            if (loggedUser != null)
            {
                Fitters.app.calorieTracker.AuthUser(loggedUser);
                parent.Dispose();
                this.Dispose();
            }
            else
                MessageBox.Show("Błędne dane");
        }
    }
}
