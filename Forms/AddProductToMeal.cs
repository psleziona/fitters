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
        RefreshDataGridView showProducts;
  
        public AddProductToMeal(DateTime date, Type meatType, RefreshDataGridView showProducts)
        {
            InitializeComponent();
            this.date = date;
            this.meatType = meatType;
            this.showProducts = showProducts;
            FillDataGrid(Fitters.app.calorieTracker.ProductsService.Products);
        }

        private void buttonAddProductToMeal_Click(object sender, EventArgs e)
        {
            string productName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Product p = Fitters.app.calorieTracker.ProductsService.Products.Find(x => x.Name == productName);
            double quantity = double.Parse(textBox2.Text.Replace('.',','));
            Fitters.app.calorieTracker.UserService.AddProductToMeal(date, new MealProductQuantity(p, quantity), meatType);
            showProducts.Invoke();
            this.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string value = textBoxSearch.Text.ToLower();
            List<Product> filtered = Fitters.app.calorieTracker.ProductsService.Products
                .Where(p => p.Name.ToLower().StartsWith(value)).ToList();
            FillDataGrid(filtered);
        }

        private void FillDataGrid(List<Product> products)
        {
            dataGridView1.Rows.Clear();
            foreach (var p in products)
            {
                dataGridView1.Rows.Add(p.Name, p.GetCalories());
            }
        }
    }
}
