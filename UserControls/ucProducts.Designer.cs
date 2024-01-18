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
            this.buttonAddProductToBase = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxProductUnit = new System.Windows.Forms.ComboBox();
            this.checkBoxIsProductCountable = new System.Windows.Forms.CheckBox();
            this.textBoxProductAmount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxProductCarbon = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxProductFat = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxProductProtein = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proteins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carbs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kcal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddProductToBase
            // 
            this.buttonAddProductToBase.Location = new System.Drawing.Point(639, 415);
            this.buttonAddProductToBase.Name = "buttonAddProductToBase";
            this.buttonAddProductToBase.Size = new System.Drawing.Size(200, 49);
            this.buttonAddProductToBase.TabIndex = 31;
            this.buttonAddProductToBase.Text = "Dodaj";
            this.buttonAddProductToBase.UseVisualStyleBackColor = true;
            this.buttonAddProductToBase.Click += new System.EventHandler(this.buttonAddProductToBase_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(639, 353);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 15);
            this.label15.TabIndex = 30;
            this.label15.Text = "Jednostka";
            // 
            // comboBoxProductUnit
            // 
            this.comboBoxProductUnit.Enabled = false;
            this.comboBoxProductUnit.FormattingEnabled = true;
            this.comboBoxProductUnit.Location = new System.Drawing.Point(639, 371);
            this.comboBoxProductUnit.Name = "comboBoxProductUnit";
            this.comboBoxProductUnit.Size = new System.Drawing.Size(200, 23);
            this.comboBoxProductUnit.TabIndex = 29;
            // 
            // checkBoxIsProductCountable
            // 
            this.checkBoxIsProductCountable.AutoSize = true;
            this.checkBoxIsProductCountable.Checked = true;
            this.checkBoxIsProductCountable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsProductCountable.Location = new System.Drawing.Point(644, 266);
            this.checkBoxIsProductCountable.Name = "checkBoxIsProductCountable";
            this.checkBoxIsProductCountable.Size = new System.Drawing.Size(79, 19);
            this.checkBoxIsProductCountable.TabIndex = 28;
            this.checkBoxIsProductCountable.Text = "Policzalne";
            this.checkBoxIsProductCountable.UseVisualStyleBackColor = true;
            this.checkBoxIsProductCountable.CheckedChanged += new System.EventHandler(this.checkBoxIsProductCountable_CheckedChanged);
            // 
            // textBoxProductAmount
            // 
            this.textBoxProductAmount.Enabled = false;
            this.textBoxProductAmount.Location = new System.Drawing.Point(639, 317);
            this.textBoxProductAmount.Name = "textBoxProductAmount";
            this.textBoxProductAmount.Size = new System.Drawing.Size(200, 23);
            this.textBoxProductAmount.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(644, 299);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 15);
            this.label14.TabIndex = 26;
            this.label14.Text = "Ilość";
            // 
            // textBoxProductCarbon
            // 
            this.textBoxProductCarbon.Location = new System.Drawing.Point(644, 227);
            this.textBoxProductCarbon.Name = "textBoxProductCarbon";
            this.textBoxProductCarbon.Size = new System.Drawing.Size(195, 23);
            this.textBoxProductCarbon.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(644, 195);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(166, 15);
            this.label13.TabIndex = 24;
            this.label13.Text = "Zawartość węglowodanów [g]";
            // 
            // textBoxProductFat
            // 
            this.textBoxProductFat.Location = new System.Drawing.Point(644, 158);
            this.textBoxProductFat.Name = "textBoxProductFat";
            this.textBoxProductFat.Size = new System.Drawing.Size(195, 23);
            this.textBoxProductFat.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(644, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "Zawartość tłuszczy [g]";
            // 
            // textBoxProductProtein
            // 
            this.textBoxProductProtein.Location = new System.Drawing.Point(644, 98);
            this.textBoxProductProtein.Name = "textBoxProductProtein";
            this.textBoxProductProtein.Size = new System.Drawing.Size(195, 23);
            this.textBoxProductProtein.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(644, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "Zawartość białka [g]";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(644, 41);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(195, 23);
            this.textBoxProductName.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(644, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Nazwa";
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.proteins,
            this.carbs,
            this.fats,
            this.qty,
            this.kcal});
            this.dataGridViewProducts.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersVisible = false;
            this.dataGridViewProducts.RowTemplate.Height = 25;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(603, 832);
            this.dataGridViewProducts.TabIndex = 17;
            // 
            // name
            // 
            this.name.HeaderText = "Nazwa";
            this.name.Name = "name";
            // 
            // proteins
            // 
            this.proteins.HeaderText = "Białka";
            this.proteins.Name = "proteins";
            // 
            // carbs
            // 
            this.carbs.HeaderText = "Węglowodany";
            this.carbs.Name = "carbs";
            // 
            // fats
            // 
            this.fats.HeaderText = "Tłuszcze";
            this.fats.Name = "fats";
            // 
            // qty
            // 
            this.qty.HeaderText = "Ilość";
            this.qty.Name = "qty";
            // 
            // kcal
            // 
            this.kcal.HeaderText = "Kalorie";
            this.kcal.Name = "kcal";
            // 
            // ucProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAddProductToBase);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBoxProductUnit);
            this.Controls.Add(this.checkBoxIsProductCountable);
            this.Controls.Add(this.textBoxProductAmount);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxProductCarbon);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxProductFat);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxProductProtein);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridViewProducts);
            this.Name = "ucProducts";
            this.Size = new System.Drawing.Size(1335, 846);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
