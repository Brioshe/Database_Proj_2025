using Microsoft.Data.SqlClient;
using System.Data;

namespace DatabaseIntegration;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        // DB Connection
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Chapter7;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection myconnection = new(connectionString);
        myconnection.Open();
        myconnection.Close();

        // Dropdown Box Stuff
        string[] states = { "PA", "NY", "NJ" };
        comboBox1.Items.AddRange(states);
        if (comboBox1.Items.Count > 0) comboBox1.SelectedIndex = 0;
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        string sqlQuery = "SELECT * FROM Agents";
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Chapter7;Integrated Security=True;TrustServerCertificate=True";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }
    }
}
