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
            cmbYear = new ComboBox();
            cmbMake = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            cmbModel = new ComboBox();
            txtLP = new TextBox();
            label4 = new Label();
            label1 = new Label();
            cmbCustomer = new ComboBox();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(395, 295);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(89, 31);
            button4.TabIndex = 21;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(299, 295);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(89, 31);
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
            panel1.Location = new Point(-32, -7);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(571, 88);
            panel1.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(41, 16);
            label12.Name = "label12";
            label12.Size = new Size(130, 28);
            label12.TabIndex = 18;
            label12.Text = "Vehicle Entry";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(42, 47);
            label11.Name = "label11";
            label11.Size = new Size(326, 23);
            label11.TabIndex = 16;
            label11.Text = "Register a new vehicle into the database";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbYear);
            groupBox2.Controls.Add(cmbMake);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(cmbModel);
            groupBox2.Controls.Add(txtLP);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(11, 161);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(473, 120);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Vehicle";
            // 
            // cmbYear
            // 
            cmbYear.FormattingEnabled = true;
            cmbYear.Location = new Point(395, 68);
            cmbYear.Margin = new Padding(3, 4, 3, 4);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(63, 28);
            cmbYear.TabIndex = 20;
            // 
            // cmbMake
            // 
            cmbMake.FormattingEnabled = true;
            cmbMake.Location = new Point(326, 29);
            cmbMake.Margin = new Padding(3, 4, 3, 4);
            cmbMake.Name = "cmbMake";
            cmbMake.Size = new Size(133, 28);
            cmbMake.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(355, 72);
            label10.Name = "label10";
            label10.Size = new Size(37, 20);
            label10.TabIndex = 23;
            label10.Text = "Year";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(69, 72);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 22;
            label9.Text = "Model";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(278, 33);
            label8.Name = "label8";
            label8.Size = new Size(45, 20);
            label8.TabIndex = 21;
            label8.Text = "Make";
            // 
            // cmbModel
            // 
            cmbModel.FormattingEnabled = true;
            cmbModel.Location = new Point(122, 68);
            cmbModel.Margin = new Padding(3, 4, 3, 4);
            cmbModel.Name = "cmbModel";
            cmbModel.Size = new Size(226, 28);
            cmbModel.TabIndex = 19;
            // 
            // txtLP
            // 
            txtLP.Location = new Point(122, 29);
            txtLP.Margin = new Padding(3, 4, 3, 4);
            txtLP.Name = "txtLP";
            txtLP.Size = new Size(148, 27);
            txtLP.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 33);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 17;
            label4.Text = "License Plate #";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 115);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 29;
            label1.Text = "Vehicle Owner";
            // 
            // cmbCustomer
            // 
            cmbCustomer.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(134, 111);
            cmbCustomer.Margin = new Padding(3, 4, 3, 4);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(337, 28);
            cmbCustomer.TabIndex = 24;
            cmbCustomer.Text = "Customer...";
            // 
            // AddVehicle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 337);
            Controls.Add(cmbCustomer);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddVehicle";
            Text = "Form2";
            Load += AddVehicle_Load;
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
        private ComboBox cmbYear;
        private ComboBox cmbMake;
        private Label label10;
        private Label label9;
        private Label label8;
        private ComboBox cmbModel;
        private TextBox txtLP;
        private Label label4;
        private Label label1;
        private ComboBox cmbCustomer;
    }
}