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
            label11 = new Label();
            panel1 = new Panel();
            label12 = new Label();
            groupBox1 = new GroupBox();
            txtFN = new TextBox();
            txtLN = new TextBox();
            label1 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            label4 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            comboBox4 = new ComboBox();
            label5 = new Label();
            groupBox2 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            servicetxt = new TextBox();
            costtxt = new TextBox();
            button1 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(407, 751);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(89, 31);
            button4.TabIndex = 29;
            button4.Text = "Close";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(53, 45);
            label11.Name = "label11";
            label11.Size = new Size(447, 23);
            label11.TabIndex = 16;
            label11.Text = "Enter technician information and associate with services\r\n";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Location = new Point(-38, -3);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(953, 92);
            panel1.TabIndex = 27;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(51, 15);
            label12.Name = "label12";
            label12.Size = new Size(344, 28);
            label12.TabIndex = 18;
            label12.Text = "Technician and Service Management";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(txtFN);
            groupBox1.Controls.Add(txtLN);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(15, 125);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(481, 163);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Technician";
            // 
            // txtFN
            // 
            txtFN.Location = new Point(112, 29);
            txtFN.Margin = new Padding(3, 4, 3, 4);
            txtFN.Name = "txtFN";
            txtFN.Size = new Size(349, 27);
            txtFN.TabIndex = 7;
            // 
            // txtLN
            // 
            txtLN.Location = new Point(112, 68);
            txtLN.Margin = new Padding(3, 4, 3, 4);
            txtLN.Name = "txtLN";
            txtLN.Size = new Size(349, 27);
            txtLN.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 72);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 3;
            label1.Text = "Last name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 33);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
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
            groupBox3.Location = new Point(15, 302);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(481, 209);
            groupBox3.TabIndex = 31;
            groupBox3.TabStop = false;
            groupBox3.Text = "Associate Service";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(159, 164);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 42;
            label4.Text = "Added Services";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ButtonHighlight;
            textBox2.Location = new Point(280, 47);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(182, 140);
            textBox2.TabIndex = 41;
            // 
            // button2
            // 
            button2.Location = new Point(203, 85);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(70, 31);
            button2.TabIndex = 40;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(113, 47);
            comboBox4.Margin = new Padding(3, 4, 3, 4);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(159, 28);
            comboBox4.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 52);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 38;
            label5.Text = "Add Service";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(costtxt);
            groupBox2.Controls.Add(servicetxt);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(15, 529);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(481, 192);
            groupBox2.TabIndex = 32;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Service";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 53);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 38;
            label7.Text = "Service Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 92);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 39;
            label6.Text = "Service Cost";
            // 
            // servicetxt
            // 
            servicetxt.Location = new Point(112, 50);
            servicetxt.Margin = new Padding(3, 4, 3, 4);
            servicetxt.Name = "servicetxt";
            servicetxt.Size = new Size(349, 27);
            servicetxt.TabIndex = 17;
            // 
            // costtxt
            // 
            costtxt.Location = new Point(112, 89);
            costtxt.Margin = new Padding(3, 4, 3, 4);
            costtxt.Name = "costtxt";
            costtxt.Size = new Size(349, 27);
            costtxt.TabIndex = 40;
            // 
            // button1
            // 
            button1.Location = new Point(373, 139);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(89, 31);
            button1.TabIndex = 33;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(372, 113);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(89, 31);
            button3.TabIndex = 41;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            // 
            // TechMgmt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 795);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(panel1);
            Name = "TechMgmt";
            Text = "TechMgmt";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button4;
        private Label label11;
        private Panel panel1;
        private Label label12;
        private GroupBox groupBox1;
        private TextBox txtFN;
        private TextBox txtLN;
        private Label label1;
        private Label label3;
        private GroupBox groupBox3;
        private Label label4;
        private TextBox textBox2;
        private Button button2;
        private ComboBox comboBox4;
        private Label label5;
        private GroupBox groupBox2;
        private Button button1;
        private TextBox costtxt;
        private TextBox servicetxt;
        private Label label6;
        private Label label7;
        private Button button3;
    }
}