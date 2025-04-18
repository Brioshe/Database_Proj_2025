using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace DatabaseIntegration
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                using (var context = new MechanicShopContext())
                {
                    context.Database.OpenConnection();
                    Console.WriteLine("Database connection successful!");
                    context.Database.CloseConnection();
                }

                ApplicationConfiguration.Initialize();
                Application.Run(new GUIAccess());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to connect to database: {ex.Message}");
            }
        }
    }

    public class MechanicShopContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<CarOwner> CarOwner { get; set; }
        public DbSet<Service> Services { get; set; } 
        public DbSet<Technician> Technicians { get; set; }
        public DbSet<TechnicianService> TechnicianServices { get; set; }
        public DbSet<CustomerCarServiceAppointment> CustomerCarServiceAppointments { get; set; }
        public DbSet<AppointmentService> AppointmentServices { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=DESKTOP-59EFNMM\SQLEXPRESS;Initial Catalog=MechanicShop;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }

    public class Customer
    {
        [Key]
        public int customer_id { get; set; }
        public string? first_name { get; set; }
        public string? last_name { get; set; }
        public string? phone_number { get; set; }
    }

    public class Car
    {
        [Key]
        public int car_id { get; set; }
        public string? license_plate { get; set; }
        public int make_id { get; set; }
        public int model_id { get; set; }
    }

    public class Make
    {
        [Key]
        public int make_id { get; set; }
        public string? make_name {  get; set; }
    }

    public class Model
    {
        [Key]
        public int model_id { get; set; }
        public string? model_name { get; set; }
    }

    public class CarOwner
    {
        [Key]
        public int car_owner_id { get; set; }
        public int customer_id { get; set; }
        public int car_id { get; set; }
    }

    public class Service
    {
        [Key]
        public int service_id { get; set; }
        public string? service_name { get; set; }
        public decimal cost { get; set; }
    }

    public class Technician
    {
        [Key]
        public int technician_id { get; set; }
        public string? first_name { get; set; }
        public string? last_name { get; set; }
    }

    public class TechnicianService
    {
        [Key]
        public int technician_service_id { get; set; }
        public int technician_id { get; set; }
        public int service_id { get; set; }
    }

    public class CustomerCarServiceAppointment
    {
        [Key]
        public int appointment_id { get; set; }
        public int car_owner_id { get; set; }
        public string? service_date { get; set; }
        public string? service_time { get; set; }
    }

    public class AppointmentService
    {
        [Key]
        public int appointment_service_iD { get; set; }
        public int appointment_id { get; set; }
        public int technicianservice_id { get; set; }
    }
}