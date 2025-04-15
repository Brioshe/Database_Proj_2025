using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseIntegration
{
    public partial class GUIAccess : Form
    {
        public GUIAccess()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e) // Add customer
        {
            AddCustomer newCustomerForm = new AddCustomer();
            newCustomerForm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e) // Add Vehicle
        {
            AddVehicle newVehicleForm = new AddVehicle();
            newVehicleForm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e) // Schedule Appointment
        {
            SchedAppt newAppointmentForm = new SchedAppt();
            newAppointmentForm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e) // Technician Management
        {
            TechMgmt newTechnicianForm = new TechMgmt();
            newTechnicianForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e) // Close
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
