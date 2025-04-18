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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e) // Close
        {
            Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using(var context = new MechanicShopContext())
                {
                    var newCustomer = new Customer
                    {
                        first_name = txtFirstName.Text.Trim(),
                        last_name = txtLastName.Text.Trim(),
                        phone_number = txtPhone.Text.Trim()
                    };

                    context.Customers.Add(newCustomer);
                    context.SaveChanges();

                    MessageBox.Show("Customer added successfully!");
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    txtPhone.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding customer: " + ex.Message);
            }
        }
    }
}
