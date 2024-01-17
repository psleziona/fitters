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
        private Type meatType;
        public AddProductToMeal(DateTime date, Type meatType)
        {
            InitializeComponent();
            this.date = date;
            this.meatType = meatType;
            foreach (var p in Fitters.app.calorieTracker.ProductsService.Products)
            {
                dataGridView1.Rows.Add(p.Name, p.GetCalories());
            }
        }

        private void buttonAddProductToMeal_Click(object sender, EventArgs e)
        {
            var x = dataGridView1.SelectedRows;
            string productName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Product p = Fitters.app.calorieTracker.ProductsService.Products.Find(x => x.Name == productName);
            double quantity = double.Parse(textBox2.Text);
            Fitters.app.calorieTracker.UserService.AddProductToMeal(date, new MealProductQuantity(p, quantity), meatType);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var x = dataGridView1.SelectedRows;
        }
    }
}
