namespace Fitters
{
    partial class AddUserActivity
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
            this.buttonAddUserActivity = new System.Windows.Forms.Button();
            this.textBoxTimeSpent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameActivity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddUserActivity
            // 
            this.buttonAddUserActivity.Location = new System.Drawing.Point(298, 173);
            this.buttonAddUserActivity.Name = "buttonAddUserActivity";
            this.buttonAddUserActivity.Size = new System.Drawing.Size(135, 45);
            this.buttonAddUserActivity.TabIndex = 11;
            this.buttonAddUserActivity.Text = "Dodaj";
            this.buttonAddUserActivity.UseVisualStyleBackColor = true;
            this.buttonAddUserActivity.Click += new System.EventHandler(this.buttonAddUserActivity_Click);
            // 
            // textBoxTimeSpent
            // 
            this.textBoxTimeSpent.Location = new System.Drawing.Point(298, 35);
            this.textBoxTimeSpent.Name = "textBoxTimeSpent";
            this.textBoxTimeSpent.Size = new System.Drawing.Size(135, 23);
            this.textBoxTimeSpent.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Czas [minuty]";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameActivity,
            this.Calories});
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(271, 183);
            this.dataGridView1.TabIndex = 8;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(65, 6);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(218, 23);
            this.textBoxSearch.TabIndex = 7;
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Szukaj";
            // 
            // NameActivity
            // 
            this.NameActivity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameActivity.HeaderText = "Nazwa";
            this.NameActivity.Name = "NameActivity";
            this.NameActivity.ReadOnly = true;
            // 
            // Calories
            // 
            this.Calories.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Calories.HeaderText = "Spalone kalorie";
            this.Calories.Name = "Calories";
            this.Calories.ReadOnly = true;
            // 
            // AddUserActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 234);
            this.Controls.Add(this.buttonAddUserActivity);
            this.Controls.Add(this.textBoxTimeSpent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label1);
            this.Name = "AddUserActivity";
            this.Text = "AddUserActivity";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAddUserActivity;
        private TextBox textBoxTimeSpent;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox textBoxSearch;
        private Label label1;
        private DataGridViewTextBoxColumn NameActivity;
        private DataGridViewTextBoxColumn Calories;
    }
}