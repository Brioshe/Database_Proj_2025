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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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

        private void button2_Click(object sender, EventArgs e)
        {
            using (var context = new MechanicShopContext())
            {
                var firstName = fNameBox.Text;
                var lastName = lNameBox.Text;

                CustomerServiceHistory(context, firstName, lastName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new MechanicShopContext())
            {
                var techFirst = techfirst.Text;
                var techLast = techlast.Text;
                DateTime date1 = datestart1.Value.Date;
                DateTime date2 = dateend1.Value.Date;

                TechPeriodHistory(context, techFirst, techLast, date1, date2);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            using (var context = new MechanicShopContext())
            {
                DateTime datein = dateTimePicker6.Value.Date;

                DayServices(context, datein);
            }
        }

        private void SQLGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DayServices(MechanicShopContext context, DateTime dateIn)
        {
            using (var command = context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT * FROM dbo.DayServices(@date)";
                command.CommandType = CommandType.Text;

                var date = command.CreateParameter();
                date.ParameterName = "@date";
                date.Value = dateIn;
                command.Parameters.Add(date);

                var dataTable = new DataTable();

                if (context.Database.GetDbConnection().State != ConnectionState.Open)
                    context.Database.GetDbConnection().Open();

                using (var reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }

                SQLGrid.DataSource = dataTable;
            }
        }

        private void CustomerServiceHistory(MechanicShopContext context, string firstName, string lastName)
        {
            using (var command = context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT * FROM dbo.CustomerServiceHistory(@first, @last)";
                command.CommandType = CommandType.Text;

                var fName = command.CreateParameter();
                fName.ParameterName = "@first";
                fName.Value = firstName;
                command.Parameters.Add(fName);

                var lName = command.CreateParameter();
                lName.ParameterName = "@last";
                lName.Value = lastName;
                command.Parameters.Add(lName);

                var dataTable = new DataTable();

                if (context.Database.GetDbConnection().State != ConnectionState.Open)
                    context.Database.GetDbConnection().Open();

                using (var reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }

                SQLGrid.DataSource = dataTable;
            }
        }

        private void TechPeriodHistory(MechanicShopContext context, string firstName, string lastName, DateTime start, DateTime end)
        {
            using (var command = context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT * FROM dbo.TechPeriodHistory(@first, @last, @sDate, @eDate)";
                command.CommandType = CommandType.Text;

                var fName = command.CreateParameter();
                fName.ParameterName = "@first";
                fName.Value = firstName;
                command.Parameters.Add(fName);

                var lName = command.CreateParameter();
                lName.ParameterName = "@last";
                lName.Value = lastName;
                command.Parameters.Add(lName);

                var sDate = command.CreateParameter();
                sDate.ParameterName = "@sDate";
                sDate.Value = start;
                command.Parameters.Add(sDate);

                var eDate = command.CreateParameter();
                eDate.ParameterName = "@eDate";
                eDate.Value = end;
                command.Parameters.Add(eDate);

                var dataTable = new DataTable();

                if (context.Database.GetDbConnection().State != ConnectionState.Open)
                    context.Database.GetDbConnection().Open();

                using (var reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }

                SQLGrid.DataSource = dataTable;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (var context = new MechanicShopContext())
            {
                DateTime date1 = TOPDATE1.Value.Date;
                DateTime date2 = TOPDATE2.Value.Date;

                TopGuy(context, date1, date2);
            }
        }

        private void TopGuy(MechanicShopContext context, DateTime start, DateTime end)
        {
            using (var command = context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT dbo.TopGuy(@sDate, @eDate)";
                command.CommandType = CommandType.Text;

                var sDate = command.CreateParameter();
                sDate.ParameterName = "@sDate";
                sDate.Value = start;
                command.Parameters.Add(sDate);

                var eDate = command.CreateParameter();
                eDate.ParameterName = "@eDate";
                eDate.Value = end;
                command.Parameters.Add(eDate);

                if (context.Database.GetDbConnection().State != ConnectionState.Open)
                    context.Database.GetDbConnection().Open();

                var result = command.ExecuteScalar();

                // Create a table with one column and one row
                var table = new DataTable();
                table.Columns.Add("Top Technician", typeof(string));

                var row = table.NewRow();
                row["Top Technician"] = result?.ToString() ?? "No result";
                table.Rows.Add(row);

                // Display it in the DataGridView
                SQLGrid.DataSource = table;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            using (var context = new MechanicShopContext())
            {
                DateTime date1 = d1.Value.Date;
                DateTime date2 = d2.Value.Date;

                TotalRev(context, date1, date2);
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void TotalRev(MechanicShopContext context, DateTime start, DateTime end)
        {
            using (var command = context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT dbo.TotalRevenue(@sDate, @eDate)";
                command.CommandType = CommandType.Text;

                var sDate = command.CreateParameter();
                sDate.ParameterName = "@sDate";
                sDate.Value = start;
                command.Parameters.Add(sDate);

                var eDate = command.CreateParameter();
                eDate.ParameterName = "@eDate";
                eDate.Value = end;
                command.Parameters.Add(eDate);

                if (context.Database.GetDbConnection().State != ConnectionState.Open)
                    context.Database.GetDbConnection().Open();

                var result = command.ExecuteScalar();

                // Create a table with one column and one row
                var table = new DataTable();
                table.Columns.Add("Total Revenue", typeof(string));

                var row = table.NewRow();
                row["Total Revenue"] = result?.ToString() ?? "No result";
                table.Rows.Add(row);

                // Display it in the DataGridView
                SQLGrid.DataSource = table;
            }
        }
    }
}
