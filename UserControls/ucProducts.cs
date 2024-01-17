﻿using Fitters.Models;
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
    public partial class ucProducts : UserControl
    {
        public ucProducts()
        {
            InitializeComponent();
            comboBoxProductUnit.Items.AddRange(new object[] { ProductUnit.MILLILITRE, ProductUnit.GRAM });
            foreach (var p in Fitters.app.calorieTracker.ProductsService.Products)
            {
                dataGridViewProducts.Rows.Add(p.Name, p.Proteins, p.Carbons, p.Fats, "1", p.GetCalories());
            }
            //do poprawki
        }

        private void buttonAddProductToBase_Click(object sender, EventArgs e)
        {
            string name = textBoxProductName.Text;
            double proteins = double.Parse(textBoxProductProtein.Text);
            double fats = double.Parse(textBoxProductFat.Text);
            double carbons = double.Parse(textBoxProductCarbon.Text);
            bool isCountable = checkBoxIsProductCountable.Checked;

            Product p;

            if (isCountable)
            {
                p = new ProductIndividual(name, proteins, carbons, fats);
            }
            else
            {
                int capacity = int.Parse(textBoxProductAmount.Text);
                ProductUnit unit = (ProductUnit)comboBoxProductUnit.SelectedItem;
                p = new ProductBulk(name, proteins, carbons, fats, capacity, unit);
            }
            Fitters.app.calorieTracker.ProductsService.AddProduct(p);


            //dodaj do datagrida
        }

        private void checkBoxIsProductCountable_CheckedChanged(object sender, EventArgs e)
        {
            textBoxProductAmount.Enabled = !checkBoxIsProductCountable.Checked;
            comboBoxProductUnit.Enabled = !checkBoxIsProductCountable.Checked;
        }
    }
}
