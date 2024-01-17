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
            buttonAddActivityToBase = new Button();
            textBoxActivityBurnedCalories = new TextBox();
            label20 = new Label();
            textBoxActivityName = new TextBox();
            label21 = new Label();
            dataGridViewActivities = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewActivities).BeginInit();
            SuspendLayout();
            // 
            // buttonAddActivityToBase
            // 
            buttonAddActivityToBase.Location = new Point(635, 138);
            buttonAddActivityToBase.Name = "buttonAddActivityToBase";
            buttonAddActivityToBase.Size = new Size(200, 49);
            buttonAddActivityToBase.TabIndex = 37;
            buttonAddActivityToBase.Text = "Dodaj";
            buttonAddActivityToBase.UseVisualStyleBackColor = true;
            buttonAddActivityToBase.Click += buttonAddActivityToBase_Click;
            // 
            // textBoxActivityBurnedCalories
            // 
            textBoxActivityBurnedCalories.Location = new Point(635, 89);
            textBoxActivityBurnedCalories.Name = "textBoxActivityBurnedCalories";
            textBoxActivityBurnedCalories.Size = new Size(195, 23);
            textBoxActivityBurnedCalories.TabIndex = 36;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(635, 71);
            label20.Name = "label20";
            label20.Size = new Size(86, 15);
            label20.TabIndex = 35;
            label20.Text = "Spalane kalorie";
            // 
            // textBoxActivityName
            // 
            textBoxActivityName.Location = new Point(635, 32);
            textBoxActivityName.Name = "textBoxActivityName";
            textBoxActivityName.Size = new Size(195, 23);
            textBoxActivityName.TabIndex = 34;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(635, 14);
            label21.Name = "label21";
            label21.Size = new Size(42, 15);
            label21.TabIndex = 33;
            label21.Text = "Nazwa";
            // 
            // dataGridViewActivities
            // 
            dataGridViewActivities.AllowUserToAddRows = false;
            dataGridViewActivities.AllowUserToDeleteRows = false;
            dataGridViewActivities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewActivities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewActivities.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn6 });
            dataGridViewActivities.Location = new Point(3, 3);
            dataGridViewActivities.Name = "dataGridViewActivities";
            dataGridViewActivities.RowHeadersVisible = false;
            dataGridViewActivities.RowTemplate.Height = 25;
            dataGridViewActivities.Size = new Size(603, 832);
            dataGridViewActivities.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Nazwa";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Spalane kalorie";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // ucActivities
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonAddActivityToBase);
            Controls.Add(textBoxActivityBurnedCalories);
            Controls.Add(label20);
            Controls.Add(textBoxActivityName);
            Controls.Add(label21);
            Controls.Add(dataGridViewActivities);
            Name = "ucActivities";
            Size = new Size(1335, 846);
            ((System.ComponentModel.ISupportInitialize)dataGridViewActivities).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
