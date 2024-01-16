namespace Fitters
{
    partial class AddProductToMeal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Calories = new DataGridViewTextBoxColumn();
            label2 = new Label();
            textBox2 = new TextBox();
            buttonAddProductToMeal = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Szukaj";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(65, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 23);
            textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, Calories });
            dataGridView1.Location = new Point(12, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(271, 183);
            dataGridView1.TabIndex = 2;
            // 
            // Name
            // 
            Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Name.HeaderText = "Name";
            Name.Name = "Name";
            // 
            // Calories
            // 
            Calories.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Calories.HeaderText = "Calories";
            Calories.Name = "Calories";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(298, 9);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 3;
            label2.Text = "Ilość";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(298, 35);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(135, 23);
            textBox2.TabIndex = 4;
            // 
            // buttonAddProductToMeal
            // 
            buttonAddProductToMeal.Location = new Point(298, 173);
            buttonAddProductToMeal.Name = "buttonAddProductToMeal";
            buttonAddProductToMeal.Size = new Size(135, 45);
            buttonAddProductToMeal.TabIndex = 5;
            buttonAddProductToMeal.Text = "Dodaj";
            buttonAddProductToMeal.UseVisualStyleBackColor = true;
            // 
            // AddProductToMeal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 230);
            Controls.Add(buttonAddProductToMeal);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "AddProductToMeal";
            Text = "AddProductToMeal";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Calories;
        private Label label2;
        private TextBox textBox2;
        private Button buttonAddProductToMeal;
    }
}