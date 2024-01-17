namespace Fitters.UserControls
{
    partial class ucProducts
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAddProductToBase = new Button();
            label15 = new Label();
            comboBoxProductUnit = new ComboBox();
            checkBoxIsProductCountable = new CheckBox();
            textBoxProductAmount = new TextBox();
            label14 = new Label();
            textBoxProductCarbon = new TextBox();
            label13 = new Label();
            textBoxProductFat = new TextBox();
            label12 = new Label();
            textBoxProductProtein = new TextBox();
            label11 = new Label();
            textBoxProductName = new TextBox();
            label10 = new Label();
            dataGridViewProducts = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            proteins = new DataGridViewTextBoxColumn();
            carbs = new DataGridViewTextBoxColumn();
            fats = new DataGridViewTextBoxColumn();
            qty = new DataGridViewTextBoxColumn();
            kcal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // buttonAddProductToBase
            // 
            buttonAddProductToBase.Location = new Point(639, 415);
            buttonAddProductToBase.Name = "buttonAddProductToBase";
            buttonAddProductToBase.Size = new Size(200, 49);
            buttonAddProductToBase.TabIndex = 31;
            buttonAddProductToBase.Text = "Dodaj";
            buttonAddProductToBase.UseVisualStyleBackColor = true;
            buttonAddProductToBase.Click += buttonAddProductToBase_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(639, 353);
            label15.Name = "label15";
            label15.Size = new Size(59, 15);
            label15.TabIndex = 30;
            label15.Text = "Jednostka";
            // 
            // comboBoxProductUnit
            // 
            comboBoxProductUnit.Enabled = false;
            comboBoxProductUnit.FormattingEnabled = true;
            comboBoxProductUnit.Location = new Point(639, 371);
            comboBoxProductUnit.Name = "comboBoxProductUnit";
            comboBoxProductUnit.Size = new Size(200, 23);
            comboBoxProductUnit.TabIndex = 29;
            // 
            // checkBoxIsProductCountable
            // 
            checkBoxIsProductCountable.AutoSize = true;
            checkBoxIsProductCountable.Checked = true;
            checkBoxIsProductCountable.CheckState = CheckState.Checked;
            checkBoxIsProductCountable.Location = new Point(644, 266);
            checkBoxIsProductCountable.Name = "checkBoxIsProductCountable";
            checkBoxIsProductCountable.Size = new Size(79, 19);
            checkBoxIsProductCountable.TabIndex = 28;
            checkBoxIsProductCountable.Text = "Policzalne";
            checkBoxIsProductCountable.UseVisualStyleBackColor = true;
            checkBoxIsProductCountable.CheckedChanged += checkBoxIsProductCountable_CheckedChanged;
            // 
            // textBoxProductAmount
            // 
            textBoxProductAmount.Enabled = false;
            textBoxProductAmount.Location = new Point(639, 317);
            textBoxProductAmount.Name = "textBoxProductAmount";
            textBoxProductAmount.Size = new Size(200, 23);
            textBoxProductAmount.TabIndex = 27;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(644, 299);
            label14.Name = "label14";
            label14.Size = new Size(31, 15);
            label14.TabIndex = 26;
            label14.Text = "Ilość";
            // 
            // textBoxProductCarbon
            // 
            textBoxProductCarbon.Location = new Point(644, 227);
            textBoxProductCarbon.Name = "textBoxProductCarbon";
            textBoxProductCarbon.Size = new Size(195, 23);
            textBoxProductCarbon.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(644, 195);
            label13.Name = "label13";
            label13.Size = new Size(148, 15);
            label13.TabIndex = 24;
            label13.Text = "Zawartość węglowodanów";
            // 
            // textBoxProductFat
            // 
            textBoxProductFat.Location = new Point(644, 158);
            textBoxProductFat.Name = "textBoxProductFat";
            textBoxProductFat.Size = new Size(195, 23);
            textBoxProductFat.TabIndex = 23;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(644, 140);
            label12.Name = "label12";
            label12.Size = new Size(105, 15);
            label12.TabIndex = 22;
            label12.Text = "Zawartość tłuszczy";
            // 
            // textBoxProductProtein
            // 
            textBoxProductProtein.Location = new Point(644, 98);
            textBoxProductProtein.Name = "textBoxProductProtein";
            textBoxProductProtein.Size = new Size(195, 23);
            textBoxProductProtein.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(644, 80);
            label11.Name = "label11";
            label11.Size = new Size(95, 15);
            label11.TabIndex = 20;
            label11.Text = "Zawartość białka";
            // 
            // textBoxProductName
            // 
            textBoxProductName.Location = new Point(644, 41);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.Size = new Size(195, 23);
            textBoxProductName.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(644, 23);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 18;
            label10.Text = "Nazwa";
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AllowUserToDeleteRows = false;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { name, proteins, carbs, fats, qty, kcal });
            dataGridViewProducts.Location = new Point(12, 12);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersVisible = false;
            dataGridViewProducts.RowTemplate.Height = 25;
            dataGridViewProducts.Size = new Size(603, 832);
            dataGridViewProducts.TabIndex = 17;
            // 
            // name
            // 
            name.HeaderText = "Nazwa";
            name.Name = "name";
            // 
            // proteins
            // 
            proteins.HeaderText = "Białka";
            proteins.Name = "proteins";
            // 
            // carbs
            // 
            carbs.HeaderText = "Węglowodany";
            carbs.Name = "carbs";
            // 
            // fats
            // 
            fats.HeaderText = "Tłuszcze";
            fats.Name = "fats";
            // 
            // qty
            // 
            qty.HeaderText = "Ilość";
            qty.Name = "qty";
            // 
            // kcal
            // 
            kcal.HeaderText = "Kalorie";
            kcal.Name = "kcal";
            // 
            // ucProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonAddProductToBase);
            Controls.Add(label15);
            Controls.Add(comboBoxProductUnit);
            Controls.Add(checkBoxIsProductCountable);
            Controls.Add(textBoxProductAmount);
            Controls.Add(label14);
            Controls.Add(textBoxProductCarbon);
            Controls.Add(label13);
            Controls.Add(textBoxProductFat);
            Controls.Add(label12);
            Controls.Add(textBoxProductProtein);
            Controls.Add(label11);
            Controls.Add(textBoxProductName);
            Controls.Add(label10);
            Controls.Add(dataGridViewProducts);
            Name = "ucProducts";
            Size = new Size(1335, 846);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddProductToBase;
        private Label label15;
        private ComboBox comboBoxProductUnit;
        private CheckBox checkBoxIsProductCountable;
        private TextBox textBoxProductAmount;
        private Label label14;
        private TextBox textBoxProductCarbon;
        private Label label13;
        private TextBox textBoxProductFat;
        private Label label12;
        private TextBox textBoxProductProtein;
        private Label label11;
        private TextBox textBoxProductName;
        private Label label10;
        private DataGridView dataGridViewProducts;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn proteins;
        private DataGridViewTextBoxColumn carbs;
        private DataGridViewTextBoxColumn fats;
        private DataGridViewTextBoxColumn qty;
        private DataGridViewTextBoxColumn kcal;
    }
}
