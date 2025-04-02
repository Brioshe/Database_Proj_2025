namespace DatabaseIntegration
{
    partial class Form3
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
            label12 = new Label();
            label11 = new Label();
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            label16 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label15 = new Label();
            label21 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            label1 = new Label();
            comboBox2 = new ComboBox();
            label2 = new Label();
            comboBox3 = new ComboBox();
            button1 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            comboBox4 = new ComboBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(38, 12);
            label12.Name = "label12";
            label12.Size = new Size(179, 21);
            label12.TabIndex = 18;
            label12.Text = "Schedule Appointment";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(39, 35);
            label11.Name = "label11";
            label11.Size = new Size(343, 17);
            label11.TabIndex = 16;
            label11.Text = "Enter information to schedule a customer's appointment";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Location = new Point(-20, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(834, 69);
            panel1.TabIndex = 16;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(comboBox4);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(comboBox3);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(dateTimePicker2);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Location = new Point(12, 145);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(533, 254);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "Appointment Information";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(10, 54);
            label16.Name = "label16";
            label16.Size = new Size(84, 15);
            label16.TabIndex = 29;
            label16.Text = "Add Mechanic";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(269, 22);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(122, 23);
            dateTimePicker2.TabIndex = 27;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(230, 25);
            label15.Name = "label15";
            label15.Size = new Size(33, 15);
            label15.TabIndex = 26;
            label15.Text = "Time";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(63, 25);
            label21.Name = "label21";
            label21.Size = new Size(31, 15);
            label21.TabIndex = 25;
            label21.Text = "Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(100, 22);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(124, 23);
            dateTimePicker1.TabIndex = 24;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(112, 83);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(427, 23);
            comboBox1.TabIndex = 30;
            comboBox1.Text = "Customer...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 86);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 31;
            label1.Text = "Vehicle Owner";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(112, 112);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(427, 23);
            comboBox2.TabIndex = 32;
            comboBox2.Text = "Vehicle...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 115);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 33;
            label2.Text = "Vehicle";
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(100, 50);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(186, 23);
            comboBox3.TabIndex = 34;
            // 
            // button1
            // 
            button1.Location = new Point(225, 79);
            button1.Name = "button1";
            button1.Size = new Size(61, 23);
            button1.TabIndex = 35;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 108);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 37;
            label3.Text = "Added Mechanics";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Location = new Point(292, 50);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(235, 73);
            textBox1.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(199, 220);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 42;
            label4.Text = "Added Services";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ButtonHighlight;
            textBox2.Location = new Point(292, 129);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(235, 106);
            textBox2.TabIndex = 41;
            // 
            // button2
            // 
            button2.Location = new Point(225, 158);
            button2.Name = "button2";
            button2.Size = new Size(61, 23);
            button2.TabIndex = 40;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(100, 129);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(186, 23);
            comboBox4.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 133);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 38;
            label5.Text = "Add Service";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Location = new Point(12, 405);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(533, 213);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Additional Notes";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ButtonHighlight;
            textBox3.Location = new Point(7, 22);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(520, 175);
            textBox3.TabIndex = 43;
            // 
            // button3
            // 
            button3.Location = new Point(383, 634);
            button3.Name = "button3";
            button3.Size = new Size(78, 23);
            button3.TabIndex = 25;
            button3.Text = "OK";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(467, 634);
            button4.Name = "button4";
            button4.Size = new Size(78, 23);
            button4.TabIndex = 26;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 669);
            Controls.Add(button4);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(groupBox3);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label12;
        private Label label11;
        private Panel panel1;
        private GroupBox groupBox3;
        private Label label16;
        private DateTimePicker dateTimePicker2;
        private Label label15;
        private Label label21;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private ComboBox comboBox3;
        private ComboBox comboBox1;
        private Label label1;
        private ComboBox comboBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Button button2;
        private ComboBox comboBox4;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox textBox3;
        private Button button3;
        private Button button4;
    }
}