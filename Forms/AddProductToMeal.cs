using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fitters.Models;

namespace Fitters
{
    public partial class AddProductToMeal : Form
    {
        private DateTime date;
        private Meal meal;
        public AddProductToMeal(DateTime date, Meal meal)
        {
            InitializeComponent();
            this.date = date;
            foreach(var p in Fitters.app.products)
            {
                dataGridView1.Rows.Add(p.Name, p.Calories);
            }
        }

        private void buttonAddProductToMeal_Click(object sender, EventArgs e)
        {
            string productName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Product p = Fitters.app.products.Find(x => x.Name == productName);
            meal.Products.Add(new MealProductQuantity(p,double.Parse(textBox2.Text)));
        }
    }
}
