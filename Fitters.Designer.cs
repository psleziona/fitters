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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPageCalendar = new TabPage();
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
            tabPageProducts = new TabPage();
            button4 = new Button();
            label15 = new Label();
            comboBox3 = new ComboBox();
            checkBox1 = new CheckBox();
            textBox5 = new TextBox();
            label14 = new Label();
            textBox4 = new TextBox();
            label13 = new Label();
            textBox3 = new TextBox();
            label12 = new Label();
            textBox2 = new TextBox();
            label11 = new Label();
            textBox1 = new TextBox();
            label10 = new Label();
            dataGridView1 = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            proteins = new DataGridViewTextBoxColumn();
            carbs = new DataGridViewTextBoxColumn();
            fats = new DataGridViewTextBoxColumn();
            qty = new DataGridViewTextBoxColumn();
            kcal = new DataGridViewTextBoxColumn();
            tabPageActivities = new TabPage();
            button5 = new Button();
            textBox9 = new TextBox();
            label20 = new Label();
            textBox10 = new TextBox();
            label21 = new Label();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            tabPageStatictics = new TabPage();
            label32 = new Label();
            label31 = new Label();
            label30 = new Label();
            label29 = new Label();
            label28 = new Label();
            label27 = new Label();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            panel45 = new Panel();
            label23 = new Label();
            panel44 = new Panel();
            label22 = new Label();
            panel43 = new Panel();
            button7 = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            tabPageUser = new TabPage();
            button6 = new Button();
            comboBox4 = new ComboBox();
            label19 = new Label();
            textBox7 = new TextBox();
            label18 = new Label();
            textBox6 = new TextBox();
            label17 = new Label();
            label16 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tabControl1.SuspendLayout();
            tabPageCalendar.SuspendLayout();
            tabPageProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPageActivities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPageStatictics.SuspendLayout();
            tabPageUser.SuspendLayout();
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
            tabControl1.TabIndexChanged += tabControl1_TabIndexChanged;
            // 
            // tabPageCalendar
            // 
            tabPageCalendar.Controls.Add(labelDate);
            tabPageCalendar.Controls.Add(panelCalendar);
            tabPageCalendar.Controls.Add(label9);
            tabPageCalendar.Controls.Add(label8);
            tabPageCalendar.Controls.Add(label7);
            tabPageCalendar.Controls.Add(label6);
            tabPageCalendar.Controls.Add(label5);
            tabPageCalendar.Controls.Add(label4);
            tabPageCalendar.Controls.Add(label3);
            tabPageCalendar.Controls.Add(buttonPreviousMonth);
            tabPageCalendar.Controls.Add(buttonNextMonth);
            tabPageCalendar.Controls.Add(buttonShowCalendar);
            tabPageCalendar.Controls.Add(comboBoxMonths);
            tabPageCalendar.Controls.Add(label2);
            tabPageCalendar.Controls.Add(label1);
            tabPageCalendar.Controls.Add(comboBoxYears);
            tabPageCalendar.Location = new Point(4, 24);
            tabPageCalendar.Name = "tabPageCalendar";
            tabPageCalendar.Padding = new Padding(3);
            tabPageCalendar.Size = new Size(1335, 846);
            tabPageCalendar.TabIndex = 0;
            tabPageCalendar.Text = "Kalendarz";
            tabPageCalendar.UseVisualStyleBackColor = true;
            // 
            // labelDate
            // 
            labelDate.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.Location = new Point(369, 10);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(790, 42);
            labelDate.TabIndex = 16;
            labelDate.Text = "MONTH YEAR";
            labelDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelCalendar
            // 
            panelCalendar.Location = new Point(14, 104);
            panelCalendar.Name = "panelCalendar";
            panelCalendar.Size = new Size(1312, 734);
            panelCalendar.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1235, 86);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 14;
            label9.Text = "Sobota";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1036, 86);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 13;
            label8.Text = "Piątek";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(854, 86);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 12;
            label7.Text = "Czwartek";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(663, 86);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 11;
            label6.Text = "Środa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(454, 86);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 10;
            label5.Text = "Wtorek";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(258, 86);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 9;
            label4.Text = "Poniedziałek";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 86);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 8;
            label3.Text = "Niedziela";
            // 
            // buttonPreviousMonth
            // 
            buttonPreviousMonth.Location = new Point(1164, 29);
            buttonPreviousMonth.Name = "buttonPreviousMonth";
            buttonPreviousMonth.Size = new Size(75, 23);
            buttonPreviousMonth.TabIndex = 7;
            buttonPreviousMonth.Text = "Poprzedni";
            buttonPreviousMonth.UseVisualStyleBackColor = true;
            buttonPreviousMonth.Click += buttonPreviousMonth_Click;
            // 
            // buttonNextMonth
            // 
            buttonNextMonth.Location = new Point(1245, 29);
            buttonNextMonth.Name = "buttonNextMonth";
            buttonNextMonth.Size = new Size(75, 23);
            buttonNextMonth.TabIndex = 6;
            buttonNextMonth.Text = "Następny";
            buttonNextMonth.UseVisualStyleBackColor = true;
            buttonNextMonth.Click += buttonNextMonth_Click;
            // 
            // buttonShowCalendar
            // 
            buttonShowCalendar.Location = new Point(287, 30);
            buttonShowCalendar.Name = "buttonShowCalendar";
            buttonShowCalendar.Size = new Size(75, 23);
            buttonShowCalendar.TabIndex = 5;
            buttonShowCalendar.Text = "Pokaż";
            buttonShowCalendar.UseVisualStyleBackColor = true;
            buttonShowCalendar.Click += buttonShowCalendar_Click;
            // 
            // comboBoxMonths
            // 
            comboBoxMonths.FormattingEnabled = true;
            comboBoxMonths.Location = new Point(145, 30);
            comboBoxMonths.Name = "comboBoxMonths";
            comboBoxMonths.Size = new Size(121, 23);
            comboBoxMonths.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 12);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "Miesiąc";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 12);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 1;
            label1.Text = "Rok";
            // 
            // comboBoxYears
            // 
            comboBoxYears.FormattingEnabled = true;
            comboBoxYears.Location = new Point(8, 30);
            comboBoxYears.Name = "comboBoxYears";
            comboBoxYears.Size = new Size(121, 23);
            comboBoxYears.TabIndex = 0;
            // 
            // tabPageProducts
            // 
            tabPageProducts.Controls.Add(button4);
            tabPageProducts.Controls.Add(label15);
            tabPageProducts.Controls.Add(comboBox3);
            tabPageProducts.Controls.Add(checkBox1);
            tabPageProducts.Controls.Add(textBox5);
            tabPageProducts.Controls.Add(label14);
            tabPageProducts.Controls.Add(textBox4);
            tabPageProducts.Controls.Add(label13);
            tabPageProducts.Controls.Add(textBox3);
            tabPageProducts.Controls.Add(label12);
            tabPageProducts.Controls.Add(textBox2);
            tabPageProducts.Controls.Add(label11);
            tabPageProducts.Controls.Add(textBox1);
            tabPageProducts.Controls.Add(label10);
            tabPageProducts.Controls.Add(dataGridView1);
            tabPageProducts.Location = new Point(4, 24);
            tabPageProducts.Name = "tabPageProducts";
            tabPageProducts.Padding = new Padding(3);
            tabPageProducts.Size = new Size(1335, 846);
            tabPageProducts.TabIndex = 1;
            tabPageProducts.Text = "Baza produktów";
            tabPageProducts.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(635, 409);
            button4.Name = "button4";
            button4.Size = new Size(200, 49);
            button4.TabIndex = 16;
            button4.Text = "Dodaj";
            button4.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(635, 347);
            label15.Name = "label15";
            label15.Size = new Size(59, 15);
            label15.TabIndex = 15;
            label15.Text = "Jednostka";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(635, 365);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(200, 23);
            comboBox3.TabIndex = 14;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(640, 260);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(79, 19);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Policzalne";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(635, 311);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(200, 23);
            textBox5.TabIndex = 10;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(640, 293);
            label14.Name = "label14";
            label14.Size = new Size(31, 15);
            label14.TabIndex = 9;
            label14.Text = "Ilość";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(640, 221);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(195, 23);
            textBox4.TabIndex = 8;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(640, 189);
            label13.Name = "label13";
            label13.Size = new Size(148, 15);
            label13.TabIndex = 7;
            label13.Text = "Zawartość węglowodanów";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(640, 152);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(195, 23);
            textBox3.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(640, 134);
            label12.Name = "label12";
            label12.Size = new Size(105, 15);
            label12.TabIndex = 5;
            label12.Text = "Zawartość tłuszczy";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(640, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(195, 23);
            textBox2.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(640, 74);
            label11.Name = "label11";
            label11.Size = new Size(95, 15);
            label11.TabIndex = 3;
            label11.Text = "Zawartość białka";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(640, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 23);
            textBox1.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(640, 17);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 1;
            label10.Text = "Nazwa";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { name, proteins, carbs, fats, qty, kcal });
            dataGridView1.Location = new Point(8, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(603, 832);
            dataGridView1.TabIndex = 0;
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
            // tabPageActivities
            // 
            tabPageActivities.Controls.Add(button5);
            tabPageActivities.Controls.Add(textBox9);
            tabPageActivities.Controls.Add(label20);
            tabPageActivities.Controls.Add(textBox10);
            tabPageActivities.Controls.Add(label21);
            tabPageActivities.Controls.Add(dataGridView2);
            tabPageActivities.Location = new Point(4, 24);
            tabPageActivities.Name = "tabPageActivities";
            tabPageActivities.Padding = new Padding(3);
            tabPageActivities.Size = new Size(1335, 846);
            tabPageActivities.TabIndex = 2;
            tabPageActivities.Text = "Baza aktywności";
            tabPageActivities.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(632, 138);
            button5.Name = "button5";
            button5.Size = new Size(200, 49);
            button5.TabIndex = 31;
            button5.Text = "Dodaj";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(632, 89);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(195, 23);
            textBox9.TabIndex = 21;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(632, 71);
            label20.Name = "label20";
            label20.Size = new Size(86, 15);
            label20.TabIndex = 20;
            label20.Text = "Spalane kalorie";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(632, 32);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(195, 23);
            textBox10.TabIndex = 19;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(632, 14);
            label21.Name = "label21";
            label21.Size = new Size(42, 15);
            label21.TabIndex = 18;
            label21.Text = "Nazwa";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn6 });
            dataGridView2.Location = new Point(0, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(603, 832);
            dataGridView2.TabIndex = 17;
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
            // tabPageStatictics
            // 
            tabPageStatictics.Controls.Add(label32);
            tabPageStatictics.Controls.Add(label31);
            tabPageStatictics.Controls.Add(label30);
            tabPageStatictics.Controls.Add(label29);
            tabPageStatictics.Controls.Add(label28);
            tabPageStatictics.Controls.Add(label27);
            tabPageStatictics.Controls.Add(label26);
            tabPageStatictics.Controls.Add(label25);
            tabPageStatictics.Controls.Add(label24);
            tabPageStatictics.Controls.Add(panel45);
            tabPageStatictics.Controls.Add(label23);
            tabPageStatictics.Controls.Add(panel44);
            tabPageStatictics.Controls.Add(label22);
            tabPageStatictics.Controls.Add(panel43);
            tabPageStatictics.Controls.Add(button7);
            tabPageStatictics.Controls.Add(dateTimePicker2);
            tabPageStatictics.Controls.Add(dateTimePicker1);
            tabPageStatictics.Location = new Point(4, 24);
            tabPageStatictics.Name = "tabPageStatictics";
            tabPageStatictics.Padding = new Padding(3);
            tabPageStatictics.Size = new Size(1335, 846);
            tabPageStatictics.TabIndex = 3;
            tabPageStatictics.Text = "Statystyki";
            tabPageStatictics.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(591, 544);
            label32.Name = "label32";
            label32.Size = new Size(38, 15);
            label32.TabIndex = 16;
            label32.Text = "Bilans";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(591, 518);
            label31.Name = "label31";
            label31.Size = new Size(171, 15);
            label31.TabIndex = 15;
            label31.Text = "Zapotrzebowanie energetyczne";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(591, 492);
            label30.Name = "label30";
            label30.Size = new Size(108, 15);
            label30.TabIndex = 14;
            label30.Text = "Spalona ilość kalori";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(591, 465);
            label29.Name = "label29";
            label29.Size = new Size(107, 15);
            label29.TabIndex = 13;
            label29.Text = "Spożyta ilość kalori";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(591, 436);
            label28.Name = "label28";
            label28.Size = new Size(95, 15);
            label28.TabIndex = 12;
            label28.Text = "Spożyte tłuszcze:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(591, 407);
            label27.Name = "label27";
            label27.Size = new Size(128, 15);
            label27.TabIndex = 11;
            label27.Text = "Spożyte węglowodany:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(591, 377);
            label26.Name = "label26";
            label26.Size = new Size(85, 15);
            label26.TabIndex = 10;
            label26.Text = "Spożyte białka:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(591, 327);
            label25.Name = "label25";
            label25.Size = new Size(128, 37);
            label25.TabIndex = 9;
            label25.Text = "Statystyki";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(588, 277);
            label24.Name = "label24";
            label24.Size = new Size(238, 15);
            label24.TabIndex = 8;
            label24.Text = "Wykres przedstawiający bilans energetyczny";
            // 
            // panel45
            // 
            panel45.Location = new Point(587, 35);
            panel45.Name = "panel45";
            panel45.Size = new Size(485, 235);
            panel45.TabIndex = 7;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(10, 566);
            label23.Name = "label23";
            label23.Size = new Size(310, 15);
            label23.TabIndex = 6;
            label23.Text = "Wykres przedstawiający wykonywane aktywności fizyczne";
            // 
            // panel44
            // 
            panel44.Location = new Point(9, 324);
            panel44.Name = "panel44";
            panel44.Size = new Size(485, 235);
            panel44.TabIndex = 5;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(9, 277);
            label22.Name = "label22";
            label22.Size = new Size(448, 15);
            label22.TabIndex = 4;
            label22.Text = "Wykres przedstawiający zawartość poszczególnych składników odżywczych w diecie";
            // 
            // panel43
            // 
            panel43.Location = new Point(8, 35);
            panel43.Name = "panel43";
            panel43.Size = new Size(485, 235);
            panel43.TabIndex = 3;
            // 
            // button7
            // 
            button7.Location = new Point(418, 6);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 2;
            button7.Text = "Pokaż";
            button7.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(212, 6);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(6, 6);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // tabPageUser
            // 
            tabPageUser.Controls.Add(button6);
            tabPageUser.Controls.Add(comboBox4);
            tabPageUser.Controls.Add(label19);
            tabPageUser.Controls.Add(textBox7);
            tabPageUser.Controls.Add(label18);
            tabPageUser.Controls.Add(textBox6);
            tabPageUser.Controls.Add(label17);
            tabPageUser.Controls.Add(label16);
            tabPageUser.Location = new Point(4, 24);
            tabPageUser.Name = "tabPageUser";
            tabPageUser.Padding = new Padding(3);
            tabPageUser.Size = new Size(1335, 846);
            tabPageUser.TabIndex = 4;
            tabPageUser.Text = "Panel użytkownika";
            tabPageUser.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(14, 232);
            button6.Name = "button6";
            button6.Size = new Size(312, 53);
            button6.TabIndex = 7;
            button6.Text = "Edytuj";
            button6.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(14, 190);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(312, 23);
            comboBox4.TabIndex = 6;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(14, 172);
            label19.Name = "label19";
            label19.Size = new Size(109, 15);
            label19.TabIndex = 5;
            label19.Text = "Poziom aktywności";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(14, 136);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(312, 23);
            textBox7.TabIndex = 4;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(14, 118);
            label18.Name = "label18";
            label18.Size = new Size(37, 15);
            label18.TabIndex = 3;
            label18.Text = "Waga";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(14, 81);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(312, 23);
            textBox6.TabIndex = 2;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(14, 63);
            label17.Name = "label17";
            label17.Size = new Size(43, 15);
            label17.TabIndex = 1;
            label17.Text = "Wzrost";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(6, 12);
            label16.Name = "label16";
            label16.Size = new Size(320, 37);
            label16.TabIndex = 0;
            label16.Text = "Informacje o użytkowniku";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
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
            tabPageCalendar.ResumeLayout(false);
            tabPageCalendar.PerformLayout();
            tabPageProducts.ResumeLayout(false);
            tabPageProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPageActivities.ResumeLayout(false);
            tabPageActivities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPageStatictics.ResumeLayout(false);
            tabPageStatictics.PerformLayout();
            tabPageUser.ResumeLayout(false);
            tabPageUser.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageCalendar;
        private TabPage tabPageProducts;
        private TabPage tabPageActivities;
        private TabPage tabPageStatictics;
        private ContextMenuStrip contextMenuStrip1;
        private TabPage tabPageUser;
        private Button buttonPreviousMonth;
        private Button buttonNextMonth;
        private Button buttonShowCalendar;
        private ComboBox comboBoxMonths;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxYears;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private FlowLayoutPanel panelCalendar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn proteins;
        private DataGridViewTextBoxColumn carbs;
        private DataGridViewTextBoxColumn fats;
        private DataGridViewTextBoxColumn qty;
        private DataGridViewTextBoxColumn kcal;
        private Button button4;
        private Label label15;
        private ComboBox comboBox3;
        private CheckBox checkBox1;
        private TextBox textBox5;
        private Label label14;
        private TextBox textBox4;
        private Label label13;
        private TextBox textBox3;
        private Label label12;
        private TextBox textBox2;
        private Label label11;
        private TextBox textBox1;
        private Label label10;
        private Button button5;
        private TextBox textBox9;
        private Label label20;
        private TextBox textBox10;
        private Label label21;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private TextBox textBox7;
        private Label label18;
        private TextBox textBox6;
        private Label label17;
        private Label label16;
        private Button button7;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button button6;
        private ComboBox comboBox4;
        private Label label19;
        private Label label23;
        private Panel panel44;
        private Label label22;
        private Panel panel43;
        private Label label32;
        private Label label31;
        private Label label30;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
        private Panel panel45;
        private Label labelDate;
    }
}