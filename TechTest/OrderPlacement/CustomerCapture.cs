using AnyCompany;
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

namespace OrderPlacement
{
    public partial class CustomerCapture : Form
    {
        private static string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Customers;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
        public CustomerCapture()
        {
            InitializeComponent();
            //var cust = CustomerRepository.Load(1);

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        public void ClearData()
        {
            txtCountry.Text = string.Empty;
            txtDOB.Text = string.Empty;
            txtName.Text = string.Empty;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ClearData();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand("SELECT count(CustomerId) FROM Customer",
                connection);
            connection.Open();
            int i = int.Parse(command.ExecuteScalar().ToString());
            i++;
            var cust = new Customer() { 
            Country = txtCountry.Text,
            DateOfBirth = dateTimePicker1.Value,
            Name = txtName.Text
            };
            CustomerRepository.Save(cust, i);
            this.ClearData();
            this.Close();
        }
    }
}
