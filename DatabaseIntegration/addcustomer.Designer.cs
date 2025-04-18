namespace DatabaseIntegration
{
    partial class AddCustomer
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
            addBtn = new Button();
            button4 = new Button();
            label11 = new Label();
            label12 = new Label();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            textBox7 = new TextBox();
            label14 = new Label();
            comboBox1 = new ComboBox();
            label13 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            txtPhone = new TextBox();
            label2 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label1 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.Location = new Point(312, 351);
            addBtn.Margin = new Padding(3, 4, 3, 4);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(89, 31);
            addBtn.TabIndex = 16;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // button4
            // 
            button4.Location = new Point(408, 351);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(89, 31);
            button4.TabIndex = 17;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(43, 45);
            label11.Name = "label11";
            label11.Size = new Size(341, 23);
            label11.TabIndex = 16;
            label11.Text = "Register a new customer into the database";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(42, 15);
            label12.Name = "label12";
            label12.Size = new Size(153, 28);
            label12.TabIndex = 18;
            label12.Text = "Customer Entry";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Location = new Point(-33, -5);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(571, 88);
            panel1.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(8, 104);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(489, 237);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Customer";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(403, 184);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(58, 27);
            textBox7.TabIndex = 26;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(371, 188);
            label14.Name = "label14";
            label14.Size = new Size(31, 20);
            label14.TabIndex = 25;
            label14.Text = "Zip";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(320, 184);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(44, 28);
            comboBox1.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(279, 188);
            label13.Name = "label13";
            label13.Size = new Size(43, 20);
            label13.TabIndex = 21;
            label13.Text = "State";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(112, 184);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(159, 27);
            textBox6.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(73, 188);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 19;
            label7.Text = "City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 149);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 18;
            label6.Text = "Address";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(112, 145);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(349, 27);
            textBox5.TabIndex = 17;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(112, 107);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(349, 27);
            txtPhone.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 111);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 8;
            label2.Text = "Phone #";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(112, 29);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(349, 27);
            txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(112, 68);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(349, 27);
            txtLastName.TabIndex = 2;
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
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 397);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(addBtn);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddCustomer";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button addBtn;
        private Button button4;
        private Label label11;
        private Label label12;
        private Panel panel1;
        private GroupBox groupBox1;
        private TextBox textBox7;
        private Label label14;
        private ComboBox comboBox1;
        private Label label13;
        private TextBox textBox6;
        private Label label7;
        private Label label6;
        private TextBox textBox5;
        private TextBox txtPhone;
        private Label label2;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label1;
        private Label label3;
    }
}