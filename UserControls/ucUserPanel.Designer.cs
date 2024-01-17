namespace Fitters.UserControls
{
    partial class ucUserPanel
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
            button6 = new Button();
            comboBox4 = new ComboBox();
            label19 = new Label();
            textBox7 = new TextBox();
            label18 = new Label();
            textBox6 = new TextBox();
            label17 = new Label();
            label16 = new Label();
            SuspendLayout();
            // 
            // button6
            // 
            button6.Location = new Point(11, 229);
            button6.Name = "button6";
            button6.Size = new Size(312, 53);
            button6.TabIndex = 15;
            button6.Text = "Edytuj";
            button6.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(11, 187);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(312, 23);
            comboBox4.TabIndex = 14;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(11, 169);
            label19.Name = "label19";
            label19.Size = new Size(109, 15);
            label19.TabIndex = 13;
            label19.Text = "Poziom aktywności";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(11, 133);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(312, 23);
            textBox7.TabIndex = 12;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(11, 115);
            label18.Name = "label18";
            label18.Size = new Size(37, 15);
            label18.TabIndex = 11;
            label18.Text = "Waga";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(11, 78);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(312, 23);
            textBox6.TabIndex = 10;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(11, 60);
            label17.Name = "label17";
            label17.Size = new Size(43, 15);
            label17.TabIndex = 9;
            label17.Text = "Wzrost";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(3, 9);
            label16.Name = "label16";
            label16.Size = new Size(320, 37);
            label16.TabIndex = 8;
            label16.Text = "Informacje o użytkowniku";
            // 
            // ucUserPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button6);
            Controls.Add(comboBox4);
            Controls.Add(label19);
            Controls.Add(textBox7);
            Controls.Add(label18);
            Controls.Add(textBox6);
            Controls.Add(label17);
            Controls.Add(label16);
            Name = "ucUserPanel";
            Size = new Size(1335, 846);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button6;
        private ComboBox comboBox4;
        private Label label19;
        private TextBox textBox7;
        private Label label18;
        private TextBox textBox6;
        private Label label17;
        private Label label16;
    }
}
