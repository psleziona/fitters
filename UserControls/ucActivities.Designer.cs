namespace Fitters.UserControls
{
    partial class ucActivities
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
            this.buttonAddActivityToBase = new System.Windows.Forms.Button();
            this.textBoxActivityBurnedCalories = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxActivityName = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.dataGridViewActivities = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivities)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddActivityToBase
            // 
            this.buttonAddActivityToBase.Location = new System.Drawing.Point(635, 138);
            this.buttonAddActivityToBase.Name = "buttonAddActivityToBase";
            this.buttonAddActivityToBase.Size = new System.Drawing.Size(200, 49);
            this.buttonAddActivityToBase.TabIndex = 37;
            this.buttonAddActivityToBase.Text = "Dodaj";
            this.buttonAddActivityToBase.UseVisualStyleBackColor = true;
            this.buttonAddActivityToBase.Click += new System.EventHandler(this.buttonAddActivityToBase_Click);
            // 
            // textBoxActivityBurnedCalories
            // 
            this.textBoxActivityBurnedCalories.Location = new System.Drawing.Point(635, 89);
            this.textBoxActivityBurnedCalories.Name = "textBoxActivityBurnedCalories";
            this.textBoxActivityBurnedCalories.Size = new System.Drawing.Size(195, 23);
            this.textBoxActivityBurnedCalories.TabIndex = 36;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(635, 71);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(147, 15);
            this.label20.TabIndex = 35;
            this.label20.Text = "Spalane kalorie na godzinę";
            // 
            // textBoxActivityName
            // 
            this.textBoxActivityName.Location = new System.Drawing.Point(635, 32);
            this.textBoxActivityName.Name = "textBoxActivityName";
            this.textBoxActivityName.Size = new System.Drawing.Size(195, 23);
            this.textBoxActivityName.TabIndex = 34;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(635, 14);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(42, 15);
            this.label21.TabIndex = 33;
            this.label21.Text = "Nazwa";
            // 
            // dataGridViewActivities
            // 
            this.dataGridViewActivities.AllowUserToAddRows = false;
            this.dataGridViewActivities.AllowUserToDeleteRows = false;
            this.dataGridViewActivities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActivities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn6});
            this.dataGridViewActivities.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewActivities.Name = "dataGridViewActivities";
            this.dataGridViewActivities.RowHeadersVisible = false;
            this.dataGridViewActivities.RowTemplate.Height = 25;
            this.dataGridViewActivities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewActivities.Size = new System.Drawing.Size(603, 832);
            this.dataGridViewActivities.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nazwa";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Spalane kalorie";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // ucActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAddActivityToBase);
            this.Controls.Add(this.textBoxActivityBurnedCalories);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textBoxActivityName);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.dataGridViewActivities);
            this.Name = "ucActivities";
            this.Size = new System.Drawing.Size(1335, 846);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAddActivityToBase;
        private TextBox textBoxActivityBurnedCalories;
        private Label label20;
        private TextBox textBoxActivityName;
        private Label label21;
        private DataGridView dataGridViewActivities;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
