namespace DatabaseIntegration
{
    partial class SchedAppt
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
            label4 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            cmbService = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            cmbTechnician = new ComboBox();
            label16 = new Label();
            timePicker = new DateTimePicker();
            label15 = new Label();
            label21 = new Label();
            datePicker = new DateTimePicker();
            cmbVehicleOwner = new ComboBox();
            label1 = new Label();
            cmbVehicle = new ComboBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            btnSetApt = new Button();
            button4 = new Button();
            btnSchedule = new Button();
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
            label12.Location = new Point(43, 16);
            label12.Name = "label12";
            label12.Size = new Size(222, 28);
            label12.TabIndex = 18;
            label12.Text = "Schedule Appointment";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(45, 47);
            label11.Name = "label11";
            label11.Size = new Size(445, 23);
            label11.TabIndex = 16;
            label11.Text = "Enter information to schedule a customer's appointment";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Location = new Point(-23, -1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(953, 92);
            panel1.TabIndex = 16;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnSchedule);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(cmbService);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(cmbTechnician);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(timePicker);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(datePicker);
            groupBox3.Location = new Point(14, 193);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(609, 339);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "Appointment Information";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(215, 259);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 42;
            label4.Text = "Added Services";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ButtonHighlight;
            textBox2.Location = new Point(334, 172);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(268, 107);
            textBox2.TabIndex = 41;
            // 
            // button2
            // 
            button2.Location = new Point(532, 300);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(70, 31);
            button2.TabIndex = 40;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cmbService
            // 
            cmbService.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cmbService.FormattingEnabled = true;
            cmbService.Location = new Point(114, 172);
            cmbService.Margin = new Padding(3, 4, 3, 4);
            cmbService.Name = "cmbService";
            cmbService.Size = new Size(212, 28);
            cmbService.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 177);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 38;
            label5.Text = "Add Service";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(210, 144);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 37;
            label3.Text = "Added Mechanics";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Location = new Point(334, 67);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(268, 96);
            textBox1.TabIndex = 36;
            // 
            // cmbTechnician
            // 
            cmbTechnician.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cmbTechnician.FormattingEnabled = true;
            cmbTechnician.Location = new Point(114, 67);
            cmbTechnician.Margin = new Padding(3, 4, 3, 4);
            cmbTechnician.Name = "cmbTechnician";
            cmbTechnician.Size = new Size(212, 28);
            cmbTechnician.TabIndex = 34;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(11, 72);
            label16.Name = "label16";
            label16.Size = new Size(104, 20);
            label16.TabIndex = 29;
            label16.Text = "Add Mechanic";
            // 
            // timePicker
            // 
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.Location = new Point(307, 29);
            timePicker.Margin = new Padding(3, 4, 3, 4);
            timePicker.Name = "timePicker";
            timePicker.Size = new Size(139, 27);
            timePicker.TabIndex = 27;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(263, 33);
            label15.Name = "label15";
            label15.Size = new Size(42, 20);
            label15.TabIndex = 26;
            label15.Text = "Time";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(72, 33);
            label21.Name = "label21";
            label21.Size = new Size(41, 20);
            label21.TabIndex = 25;
            label21.Text = "Date";
            // 
            // datePicker
            // 
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Location = new Point(114, 29);
            datePicker.Margin = new Padding(3, 4, 3, 4);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(141, 27);
            datePicker.TabIndex = 24;
            // 
            // cmbVehicleOwner
            // 
            cmbVehicleOwner.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cmbVehicleOwner.FormattingEnabled = true;
            cmbVehicleOwner.Location = new Point(128, 111);
            cmbVehicleOwner.Margin = new Padding(3, 4, 3, 4);
            cmbVehicleOwner.Name = "cmbVehicleOwner";
            cmbVehicleOwner.Size = new Size(487, 28);
            cmbVehicleOwner.TabIndex = 30;
            cmbVehicleOwner.Text = "Customer...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 115);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 31;
            label1.Text = "Vehicle Owner";
            // 
            // cmbVehicle
            // 
            cmbVehicle.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cmbVehicle.FormattingEnabled = true;
            cmbVehicle.Location = new Point(128, 149);
            cmbVehicle.Margin = new Padding(3, 4, 3, 4);
            cmbVehicle.Name = "cmbVehicle";
            cmbVehicle.Size = new Size(487, 28);
            cmbVehicle.TabIndex = 32;
            cmbVehicle.Text = "Vehicle...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 153);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 33;
            label2.Text = "Vehicle";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Location = new Point(14, 540);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(609, 284);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Additional Notes";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ButtonHighlight;
            textBox3.Location = new Point(8, 29);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(594, 232);
            textBox3.TabIndex = 43;
            // 
            // btnSetApt
            // 
            btnSetApt.Location = new Point(438, 845);
            btnSetApt.Margin = new Padding(3, 4, 3, 4);
            btnSetApt.Name = "btnSetApt";
            btnSetApt.Size = new Size(89, 31);
            btnSetApt.TabIndex = 25;
            btnSetApt.Text = "Add";
            btnSetApt.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(534, 845);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(89, 31);
            button4.TabIndex = 26;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnSchedule
            // 
            btnSchedule.Location = new Point(531, 28);
            btnSchedule.Margin = new Padding(3, 4, 3, 4);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(70, 31);
            btnSchedule.TabIndex = 43;
            btnSchedule.Text = "Set";
            btnSchedule.UseVisualStyleBackColor = true;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // SchedAppt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 892);
            Controls.Add(button4);
            Controls.Add(groupBox1);
            Controls.Add(btnSetApt);
            Controls.Add(cmbVehicle);
            Controls.Add(label2);
            Controls.Add(cmbVehicleOwner);
            Controls.Add(label1);
            Controls.Add(groupBox3);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SchedAppt";
            Text = "Form3";
            Load += Apt_Load;
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
        private DateTimePicker timePicker;
        private Label label15;
        private Label label21;
        private DateTimePicker datePicker;
        private ComboBox cmbTechnician;
        private ComboBox cmbVehicleOwner;
        private Label label1;
        private ComboBox cmbVehicle;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Button button2;
        private ComboBox cmbService;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox textBox3;
        private Button btnSetApt;
        private Button button4;
        private Button btnSchedule;
    }
}