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
    public partial class CustomerOrderCapture : Form
    {
        private static string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Customers;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
        public string _name;
        private static string _country;
        private static string _dob;
        private static int _id;
        public CustomerOrderCapture(Customer customerInfo)
        {
            InitializeComponent();
            //var cust = CustomerRepository.Load(1);
            _name = customerInfo.Name;
            _dob = customerInfo.DateOfBirth.ToString();
            _country = customerInfo.Country;
            _id = customerInfo.CustomerId;
        }
        public CustomerOrderCapture()
        {
            InitializeComponent();
            _name = string.Empty;
            _dob = string.Empty;
            _country = string.Empty;
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
            InitForm();
        }

        private void InitForm()
        {
            txtCountry.Text = _country;
            txtDOB.Text = _dob;
            txtName.Text = _name;

            if (string.IsNullOrEmpty(txtCountry.Text) && string.IsNullOrEmpty(txtCountry.Text) && string.IsNullOrEmpty(txtCountry.Text))
            {
                _id = 0;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            ////Check if Id exists
            //SqlCommand commandCheckID = new SqlCommand("SELECT CustomerId FROM Customer where CustomerId =' " + _id + "'", connection);
            //int cId = (int)commandCheckID.ExecuteScalar();


            if (_id == 0)
            {
                SqlCommand command = new SqlCommand("SELECT count(CustomerId) FROM Customer",
                    connection);
              
                int i = int.Parse(command.ExecuteScalar().ToString());
                i++;
            }

            var cust = new Customer()
            {
                Country = txtCountry.Text,
                DateOfBirth = DateTime.Parse(txtDOB.Text),
                Name = txtName.Text
            };

            var ord = new Order()
            {
                Amount = double.Parse(txtAmnt.Text),
                OrderDescription = txtDescr.Text
            };
            if (_id == 0)
                ord.CustomerId = _id;



            OrderService orderService = new OrderService();
            orderService.PlaceOrder(ord, _id);
            // CustomerRepository.Save(cust, i);
            //this.ClearData();
            //this.Close();
        }
    }
}
