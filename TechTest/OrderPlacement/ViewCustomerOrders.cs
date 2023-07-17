using AnyCompany;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderPlacement
{
    public partial class ViewCustomerOrders : Form
    {
        private static string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Customers;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
        private static int _custID;
        public ViewCustomerOrders(int customerID)
        {
            InitializeComponent();
            _custID = customerID; 
            InitForm();           

        }

        private void InitForm()
        {
            var cust = CustomerRepository.LoadCustOrderList(_custID);
            dataGridView1.DataSource = cust;
           
        }

        private void ViewCustomerOrders_Load(object sender, EventArgs e)
        {
            
           

        }
    }
}
