using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DatabaseIntegration.AddVehicle;

namespace DatabaseIntegration
{
    public partial class SchedAppt : Form
    {
        int appointmentId;

        public SchedAppt()
        {
            InitializeComponent();
        }

        public class TechnicianDisplay
        {
            public int Id { get; set; }
            public string? FullName { get; set; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PopulateOwnerDropdown()
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
                        cmbVehicleOwner.DataSource = customers;
                        cmbVehicleOwner.DisplayMember = "FullName";
                        cmbVehicleOwner.ValueMember = "Id";
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

        private void PopulateCarDropdown()
        {
            using (var context = new MechanicShopContext())
            {
                var lPlate = context.Cars.ToList();
                cmbVehicle.DataSource = lPlate;
                cmbVehicle.DisplayMember = "license_plate";
                cmbVehicle.ValueMember = "car_id";
            }
        }

        private void PopulateMechanicDropdown()
        {
            try
            {
                using (var context = new MechanicShopContext())
                {
                    var techs = context.Technicians
                        .Select(c => new TechnicianDisplay
                        {
                            Id = c.technician_id,
                            FullName = $"{c.first_name} {c.last_name}"
                        })
                        .ToList();

                    if (techs.Any())
                    {
                        cmbTechnician.DataSource = techs;
                        cmbTechnician.DisplayMember = "FullName";
                        cmbTechnician.ValueMember = "Id";
                    }
                    else
                    {
                        MessageBox.Show("No techs found in database");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading techs: {ex.Message}");
            }
        }
        private void PopulateServicesDropdown()
        {
            using (var context = new MechanicShopContext())
            {
                var services = context.Services.ToList();
                cmbService.DataSource = services;
                cmbService.DisplayMember = "service_name";
                cmbService.ValueMember = "service_id";
            }
        }

        private void Apt_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Works");
            PopulateOwnerDropdown();
            PopulateCarDropdown();
            PopulateMechanicDropdown();
            PopulateServicesDropdown();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            using (var context = new MechanicShopContext())
            {
                string vehicle = cmbVehicle.Text;
                string sqlDateFormat = datePicker.Value.ToString("yyyy-MM-dd");
                string sqlTimeFormat = timePicker.Value.ToString("HH:mm:ss");

                string[] nameParts = cmbVehicleOwner.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string ownerFirstName = nameParts.Length > 0 ? nameParts[0].Trim() : "";
                string ownerLastName = nameParts.Length > 1 ? nameParts[nameParts.Length - 1].Trim() : "";  // Take last part as the last name

                ScheduleAppointment(context, ownerFirstName, ownerLastName, vehicle, sqlDateFormat, sqlTimeFormat, out appointmentId);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            using (var context = new MechanicShopContext())
            {
                string[] nameParts = cmbTechnician.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string techFirstName = nameParts.Length > 0 ? nameParts[0] : "";
                string techLastName = nameParts.Length > 1 ? nameParts[nameParts.Length - 1] : "";  // Take last part as the last name
                string service = cmbService.Text.Trim();

                AddAppointmentService(context, appointmentId, techFirstName, techLastName, service);
            }
        }

        private void AddAppointmentService(MechanicShopContext context, int aptId, string firstname, string lastname, string servicename)
        {
            var aptIdParam = new Microsoft.Data.SqlClient.SqlParameter("@appointment_id", aptId);
            var firstNameParam = new Microsoft.Data.SqlClient.SqlParameter("@first_name", firstname);
            var lastNameParam = new Microsoft.Data.SqlClient.SqlParameter("@last_name", lastname);
            var serviceNameParam = new Microsoft.Data.SqlClient.SqlParameter("@service_name", servicename);


            context.Database.ExecuteSqlRaw("EXEC AddAppointmentService @appointment_id, @first_name, @last_name, @service_name", aptIdParam, firstNameParam, lastNameParam, serviceNameParam);
        }

        private void ScheduleAppointment(MechanicShopContext context, string firstname, string lastname, string licenseplate, string servicedate, string servicetime, out int appointmentId)
        {
            var firstNameParam = new Microsoft.Data.SqlClient.SqlParameter("@first_name", firstname);
            var lastNameParam = new Microsoft.Data.SqlClient.SqlParameter("@last_name", lastname);
            var licenseParam = new Microsoft.Data.SqlClient.SqlParameter("@license_plate", licenseplate);
            var dateParam = new Microsoft.Data.SqlClient.SqlParameter("@service_date", SqlDbType.Date)
            {
                Value = DateTime.Parse(servicedate) // Make sure the string format matches the expected Date format
            };

            // Convert servicetime string to TimeSpan
            var timeParam = new Microsoft.Data.SqlClient.SqlParameter("@service_time", SqlDbType.Time)
            {
                Value = TimeSpan.Parse(servicetime) // Make sure the string format matches the expected Time format
            };

            // Output parameter for appointment_id
            var aptidParam = new Microsoft.Data.SqlClient.SqlParameter("@appointment_id", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };


            // Execute the SQL command with parameters
            context.Database.ExecuteSqlRaw(
                "EXEC ScheduleAppointment @first_name, @last_name, @license_plate, @service_date, @service_time, @appointment_id OUTPUT",
                firstNameParam, lastNameParam, licenseParam, dateParam, timeParam, aptidParam
            );

            // Set the output value for the appointment ID
            appointmentId = Convert.ToInt32(aptidParam.Value);
        }
    }
}
