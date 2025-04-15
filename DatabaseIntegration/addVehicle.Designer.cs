namespace DatabaseIntegration
{
    partial class AddVehicle
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
            panel1 = new Panel();
            label12 = new Label();
            label11 = new Label();
            groupBox2 = new GroupBox();
            comboBox4 = new ComboBox();
            comboBox2 = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            comboBox3 = new ComboBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(346, 221);
            button4.Name = "button4";
            button4.Size = new Size(78, 23);
            button4.TabIndex = 21;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(262, 221);
            button3.Name = "button3";
            button3.Size = new Size(78, 23);
            button3.TabIndex = 20;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Location = new Point(-28, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 66);
            panel1.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(36, 12);
            label12.Name = "label12";
            label12.Size = new Size(104, 21);
            label12.TabIndex = 18;
            label12.Text = "Vehicle Entry";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(37, 35);
            label11.Name = "label11";
            label11.Size = new Size(251, 17);
            label11.TabIndex = 16;
            label11.Text = "Register a new vehicle into the database";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox4);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(10, 121);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(414, 90);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Vehicle";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(346, 51);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(56, 23);
            comboBox4.TabIndex = 20;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(285, 22);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(117, 23);
            comboBox2.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(311, 54);
            label10.Name = "label10";
            label10.Size = new Size(29, 15);
            label10.TabIndex = 23;
            label10.Text = "Year";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(60, 54);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 22;
            label9.Text = "Model";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(243, 25);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 21;
            label8.Text = "Make";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(107, 51);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(198, 23);
            comboBox3.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(107, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(130, 23);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 25);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 17;
            label4.Text = "License Plate #";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 86);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 29;
            label1.Text = "Vehicle Owner";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(117, 83);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(295, 23);
            comboBox1.TabIndex = 24;
            comboBox1.Text = "Customer...";
            // 
            // AddVehicle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 253);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(panel1);
            Name = "AddVehicle";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button4;
        private Button button3;
        private Panel panel1;
        private Label label12;
        private Label label11;
        private GroupBox groupBox2;
        private ComboBox comboBox4;
        private ComboBox comboBox2;
        private Label label10;
        private Label label9;
        private Label label8;
        private ComboBox comboBox3;
        private TextBox textBox2;
        private Label label4;
        private Label label1;
        private ComboBox comboBox1;
    }
}