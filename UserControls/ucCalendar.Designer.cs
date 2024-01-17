namespace Fitters.UserControls
{
    partial class ucCalendar
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
            labelDate = new Label();
            panelCalendar = new FlowLayoutPanel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            buttonPreviousMonth = new Button();
            buttonNextMonth = new Button();
            buttonShowCalendar = new Button();
            comboBoxMonths = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            comboBoxYears = new ComboBox();
            SuspendLayout();
            // 
            // labelDate
            // 
            labelDate.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.Location = new Point(370, 7);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(790, 42);
            labelDate.TabIndex = 32;
            labelDate.Text = "MONTH YEAR";
            labelDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelCalendar
            // 
            panelCalendar.Location = new Point(15, 101);
            panelCalendar.Name = "panelCalendar";
            panelCalendar.Size = new Size(1312, 734);
            panelCalendar.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1236, 83);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 30;
            label9.Text = "Sobota";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1037, 83);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 29;
            label8.Text = "Piątek";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(855, 83);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 28;
            label7.Text = "Czwartek";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(664, 83);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 27;
            label6.Text = "Środa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(455, 83);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 26;
            label5.Text = "Wtorek";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(259, 83);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 25;
            label4.Text = "Poniedziałek";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 83);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 24;
            label3.Text = "Niedziela";
            // 
            // buttonPreviousMonth
            // 
            buttonPreviousMonth.Location = new Point(1165, 26);
            buttonPreviousMonth.Name = "buttonPreviousMonth";
            buttonPreviousMonth.Size = new Size(75, 23);
            buttonPreviousMonth.TabIndex = 23;
            buttonPreviousMonth.Text = "Poprzedni";
            buttonPreviousMonth.UseVisualStyleBackColor = true;
            buttonPreviousMonth.Click += buttonPreviousMonth_Click;
            // 
            // buttonNextMonth
            // 
            buttonNextMonth.Location = new Point(1246, 26);
            buttonNextMonth.Name = "buttonNextMonth";
            buttonNextMonth.Size = new Size(75, 23);
            buttonNextMonth.TabIndex = 22;
            buttonNextMonth.Text = "Następny";
            buttonNextMonth.UseVisualStyleBackColor = true;
            buttonNextMonth.Click += buttonNextMonth_Click;
            // 
            // buttonShowCalendar
            // 
            buttonShowCalendar.Location = new Point(288, 27);
            buttonShowCalendar.Name = "buttonShowCalendar";
            buttonShowCalendar.Size = new Size(75, 23);
            buttonShowCalendar.TabIndex = 21;
            buttonShowCalendar.Text = "Pokaż";
            buttonShowCalendar.UseVisualStyleBackColor = true;
            buttonShowCalendar.Click += buttonShowCalendar_Click;
            // 
            // comboBoxMonths
            // 
            comboBoxMonths.FormattingEnabled = true;
            comboBoxMonths.Location = new Point(146, 27);
            comboBoxMonths.Name = "comboBoxMonths";
            comboBoxMonths.Size = new Size(121, 23);
            comboBoxMonths.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 9);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 19;
            label2.Text = "Miesiąc";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 18;
            label1.Text = "Rok";
            // 
            // comboBoxYears
            // 
            comboBoxYears.FormattingEnabled = true;
            comboBoxYears.Location = new Point(9, 27);
            comboBoxYears.Name = "comboBoxYears";
            comboBoxYears.Size = new Size(121, 23);
            comboBoxYears.TabIndex = 17;
            // 
            // ucCalendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelDate);
            Controls.Add(panelCalendar);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(buttonPreviousMonth);
            Controls.Add(buttonNextMonth);
            Controls.Add(buttonShowCalendar);
            Controls.Add(comboBoxMonths);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxYears);
            Name = "ucCalendar";
            Size = new Size(1335, 843);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDate;
        private FlowLayoutPanel panelCalendar;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button buttonPreviousMonth;
        private Button buttonNextMonth;
        private Button buttonShowCalendar;
        private ComboBox comboBoxMonths;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxYears;
    }
}
