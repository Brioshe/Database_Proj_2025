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

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new MechanicShopContext())
                {
                    var newCustomer = new Service
                    {
                        service_name = servicetxt.Text.Trim(),
                        cost = costtxt.Text.Trim()
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
