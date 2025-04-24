using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseIntegration
{
    public partial class AddVehicle : Form
    {
        public AddVehicle()
        {
            InitializeComponent();
        }
        public class CustomerDisplay
        {
            public int Id { get; set; }
            public string? FullName { get; set; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PopulateMakeDropdown()
        {
            using (var context = new MechanicShopContext())
            {
                var makes = context.Makes.ToList();
                cmbMake.DataSource = makes;
                cmbMake.DisplayMember = "make_name";
                cmbMake.ValueMember = "make_id";
            }
        }

        private void PopulateModelDropdown()
        {
            using (var context = new MechanicShopContext())
            {
                var models = context.Models.ToList();
                cmbModel.DataSource = models;
                cmbModel.DisplayMember = "model_name";
                cmbModel.ValueMember = "model_id";
            }
        }

        private void PopulateCustomerDropdown()
        {
            try
            {
                using (var context = new MechanicShopContext())
                {
                    var customers = context.Customers
                        .Select(c => new CustomerDisplay
                        {
                            Id = c.customer_id,
                            FullName = $"{c.first_name} {c.last_name}"
                        })
                        .ToList();

                    if (customers.Any())
                    {
                        cmbCustomer.DataSource = customers;
                        cmbCustomer.DisplayMember = "FullName";
                        cmbCustomer.ValueMember = "Id";
                    }
                    else
                    {
                        MessageBox.Show("No customers found in database");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers: {ex.Message}");
            }
        }

        private void AddVehicle_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Works");
            PopulateCustomerDropdown();
            PopulateMakeDropdown();
            PopulateModelDropdown();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedItem == null)
            {
                MessageBox.Show("Please select a customer");
                return;
            }

            string licensePlate = txtLP.Text;
            string make = cmbMake.Text;  // Get selected Make
            string model = cmbModel.Text;  // Get selected Model

            // Get the customer ID directly from the selected item
            int customerId = ((CustomerDisplay)cmbCustomer.SelectedItem).Id;

            using (var context = new MechanicShopContext())
            {
                // Fetch the customer data from the database using the ID
                var customer = context.Customers.FirstOrDefault(c => c.customer_id == customerId);

                if (customer != null)
                {
                    // Now call the stored procedure with the proper customer information
                    AssignCarOwner(context, customer.first_name, customer.last_name,
                                   licensePlate, make, model);
                }
                else
                {
                    MessageBox.Show("Selected customer not found in database");
                    return;
                }
            }
            Close();
        }

        private void AssignCarOwner(MechanicShopContext context, string firstName, string lastName, string licensePlate, string makeName, string modelName)
        {
            var firstNameParam = new Microsoft.Data.SqlClient.SqlParameter("@first_name", firstName);
            var lastNameParam = new Microsoft.Data.SqlClient.SqlParameter("@last_name", lastName);
            var licensePlateParam = new Microsoft.Data.SqlClient.SqlParameter("@license_plate", licensePlate);
            var makeParam = new Microsoft.Data.SqlClient.SqlParameter("@make_name", makeName);
            var modelParam = new Microsoft.Data.SqlClient.SqlParameter("@model_name", modelName);


            context.Database.ExecuteSqlRaw("EXEC AssignCarOwner @first_name, @last_name, @license_plate, @make_name, @model_name", firstNameParam, lastNameParam, licensePlateParam, makeParam, modelParam);
        }
    }
}
