namespace Fitters
{
    partial class Fitters
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
            tabControl1 = new TabControl();
            tabPageCalendar = new TabPage();
            tabPageProducts = new TabPage();
            tabPageActivities = new TabPage();
            tabPageStatictics = new TabPage();
            tabPageUser = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCalendar);
            tabControl1.Controls.Add(tabPageProducts);
            tabControl1.Controls.Add(tabPageActivities);
            tabControl1.Controls.Add(tabPageStatictics);
            tabControl1.Controls.Add(tabPageUser);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1343, 874);
            tabControl1.TabIndex = 0;
            // 
            // tabPageCalendar
            // 
            tabPageCalendar.Location = new Point(4, 24);
            tabPageCalendar.Name = "tabPageCalendar";
            tabPageCalendar.Padding = new Padding(3);
            tabPageCalendar.Size = new Size(1335, 846);
            tabPageCalendar.TabIndex = 0;
            tabPageCalendar.Text = "Kalendarz";
            tabPageCalendar.UseVisualStyleBackColor = true;
            // 
            // tabPageProducts
            // 
            tabPageProducts.Location = new Point(4, 24);
            tabPageProducts.Name = "tabPageProducts";
            tabPageProducts.Padding = new Padding(3);
            tabPageProducts.Size = new Size(1335, 846);
            tabPageProducts.TabIndex = 1;
            tabPageProducts.Text = "Baza produktów";
            tabPageProducts.UseVisualStyleBackColor = true;
            // 
            // tabPageActivities
            // 
            tabPageActivities.Location = new Point(4, 24);
            tabPageActivities.Name = "tabPageActivities";
            tabPageActivities.Padding = new Padding(3);
            tabPageActivities.Size = new Size(1335, 846);
            tabPageActivities.TabIndex = 2;
            tabPageActivities.Text = "Baza aktywności";
            tabPageActivities.UseVisualStyleBackColor = true;
            // 
            // tabPageStatictics
            // 
            tabPageStatictics.Location = new Point(4, 24);
            tabPageStatictics.Name = "tabPageStatictics";
            tabPageStatictics.Padding = new Padding(3);
            tabPageStatictics.Size = new Size(1335, 846);
            tabPageStatictics.TabIndex = 3;
            tabPageStatictics.Text = "Statystyki";
            tabPageStatictics.UseVisualStyleBackColor = true;
            // 
            // tabPageUser
            // 
            tabPageUser.Location = new Point(4, 24);
            tabPageUser.Name = "tabPageUser";
            tabPageUser.Padding = new Padding(3);
            tabPageUser.Size = new Size(1335, 846);
            tabPageUser.TabIndex = 4;
            tabPageUser.Text = "Panel użytkownika";
            tabPageUser.UseVisualStyleBackColor = true;
            // 
            // Fitters
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 874);
            Controls.Add(tabControl1);
            Name = "Fitters";
            Text = "Fitters";
            Load += Fitters_Load;
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageCalendar;
        private TabPage tabPageProducts;
        private TabPage tabPageActivities;
        private TabPage tabPageStatictics;
        private TabPage tabPageUser;
    }
}