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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new object[]
            {
                UserGender.MALE, UserGender.FEMALE,
            });
            comboBox2.Items.AddRange(new object[]
            {
                ActivityLevel.NONE, ActivityLevel.LOW, ActivityLevel.MEDIUM, ActivityLevel.HIGH,
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            int age = int.Parse(textBox3.Text);
            int height = int.Parse(textBox4.Text);
            double weight = double.Parse(textBox5.Text);
            UserGender gender = (UserGender)comboBox1.SelectedItem;
            ActivityLevel activityLevel = (ActivityLevel)comboBox2.SelectedItem;
            UserInformation userInformation = new UserInformation(weight, height, age, activityLevel);
            List<Day> days = new List<Day>()
            {
                new Day(userInformation)
            };
            Calendar calendar = new Calendar(days);
            User user = new User(login, password, gender, calendar);
            if(UserAuth.AddUser(user))
            {
                MessageBox.Show("Użytkownik dodany");
                this.Close();
            }
            
        }
    }
}
