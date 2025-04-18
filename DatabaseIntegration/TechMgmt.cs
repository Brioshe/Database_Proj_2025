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
    public partial class TechMgmt : Form
    {
        public TechMgmt()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PopulateServiceDropdown()
        {
            using (var context = new MechanicShopContext())
            {
                var services = context.Services.ToList();
                cmbService.DataSource = services;
                cmbService.DisplayMember = "service_name";
                cmbService.ValueMember = "service_id";
            }
        }

        private void TechMgmt_Load(object sender, EventArgs e)
        {
            PopulateServiceDropdown();
        }


        private void button1_Click(object sender, EventArgs e) // add service
        {
            try
            {
                using (var context = new MechanicShopContext())
                {
                    var newService = new Service
                    {
                        service_name = servicetxt.Text.Trim(),
                        cost = Decimal.Parse(costtxt.Text.Trim())
                    };

                    context.Services.Add(newService);
                    context.SaveChanges();

                    MessageBox.Show("Service added successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding service: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e) // Add service to tech
        {
            try
            {
                using (var context = new MechanicShopContext())
                {
                    // Find the technician by first name and last name
                    var technician = context.Technicians
                        .Where(t => t.first_name == txtFN.Text.Trim() && t.last_name == txtLN.Text.Trim())
                        .FirstOrDefault();

                    // Find the service by service name
                    var service = context.Services
                        .Where(s => s.service_name == cmbService.Text.Trim())
                        .FirstOrDefault();

                    if (technician == null)
                    {
                        MessageBox.Show("Technician not found. Please check the first name and last name.");
                        return;
                    }

                    if (service == null)
                    {
                        MessageBox.Show("Service not found. Please select a valid service from the dropdown.");
                        return;
                    }

                    // Create the technician-service relationship
                    var techService = new TechnicianService
                    {
                        technician_id = technician.technician_id,
                        service_id = service.service_id
                    };

                    // Add the relationship to the context and save changes
                    context.TechnicianServices.Add(techService);
                    context.SaveChanges();

                    MessageBox.Show("Service successfully assigned to technician!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error assigning service to technician: " + ex.Message);
            }
        }

        private void btnAddTech_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new MechanicShopContext())
                {
                    var newTech = new Technician
                    {
                        first_name = txtFN.Text.Trim(),
                        last_name = txtLN.Text.Trim()
                    };

                    context.Technicians.Add(newTech);
                    context.SaveChanges();

                    MessageBox.Show("Technician added successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding technician: " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (var context = new MechanicShopContext())
                {
                    var newService = new Service
                    {
                        service_name = servicetxt.Text.Trim(),
                        cost = Decimal.Parse(costtxt.Text.Trim())
                    };

                    context.Services.Add(newService);
                    context.SaveChanges();

                    MessageBox.Show("Service added successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding service: " + ex.Message);
            }
        }
    }
}
