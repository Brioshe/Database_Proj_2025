namespace DatabaseIntegration
{
    partial class TechMgmt
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
            button4 = new Button();
            button3 = new Button();
            label11 = new Label();
            panel1 = new Panel();
            label12 = new Label();
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            label4 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            comboBox4 = new ComboBox();
            label5 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(356, 409);
            button4.Name = "button4";
            button4.Size = new Size(78, 23);
            button4.TabIndex = 29;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(272, 409);
            button3.Name = "button3";
            button3.Size = new Size(78, 23);
            button3.TabIndex = 28;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(46, 34);
            label11.Name = "label11";
            label11.Size = new Size(345, 17);
            label11.TabIndex = 16;
            label11.Text = "Enter technician information and associate with services\r\n";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Location = new Point(-33, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(834, 69);
            panel1.TabIndex = 27;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(45, 11);
            label12.Name = "label12";
            label12.Size = new Size(120, 21);
            label12.TabIndex = 18;
            label12.Text = "Add Technician";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(13, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(421, 122);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Technician";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(98, 80);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(140, 23);
            textBox4.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 83);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 8;
            label2.Text = "Phone #";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(98, 22);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(306, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(98, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(306, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 54);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 3;
            label1.Text = "Last name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 25);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 5;
            label3.Text = "First name";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(comboBox4);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(13, 234);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(421, 157);
            groupBox3.TabIndex = 31;
            groupBox3.TabStop = false;
            groupBox3.Text = "Add Services";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(152, 126);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 42;
            label4.Text = "Added Services";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ButtonHighlight;
            textBox2.Location = new Point(245, 35);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(160, 106);
            textBox2.TabIndex = 41;
            // 
            // button2
            // 
            button2.Location = new Point(178, 64);
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
            comboBox4.Location = new Point(99, 35);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(140, 23);
            comboBox4.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 39);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 38;
            label5.Text = "Add Service";
            // 
            // TechMgmt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 444);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TechMgmt";
            Text = "TechMgmt";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button4;
        private Button button3;
        private Label label11;
        private Panel panel1;
        private Label label12;
        private GroupBox groupBox1;
        private TextBox textBox4;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label1;
        private Label label3;
        private GroupBox groupBox3;
        private Label label4;
        private TextBox textBox2;
        private Button button2;
        private ComboBox comboBox4;
        private Label label5;
    }
}