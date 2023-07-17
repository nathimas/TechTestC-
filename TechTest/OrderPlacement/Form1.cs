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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //var cust = CustomerRepository.Load(1);

        }

        private void BtnViewOrders_Click(object sender, EventArgs e)
        {
            var item = getItemSelected();
            ViewCustomerOrders viewCustomerOrders = new ViewCustomerOrders(item.CustomerId);
            viewCustomerOrders.ShowDialog(this);
        }

        private Customer getItemSelected()
        {
            try
            {
                var itemSlelected = dataGridView1.SelectedRows[0].DataBoundItem as Customer;
                return itemSlelected;
            }
            catch (Exception ex)
            {

                throw;
            }
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {          
           // InitForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var itemSlelected = getItemSelected();
            CustomerOrderCapture customerOrderCapture = new CustomerOrderCapture(itemSlelected);
            customerOrderCapture.ShowDialog();
            OrderService orderService = new OrderService();
            var order = new Order()
            {
                Amount = 2.00               
            };
            orderService.PlaceOrder(order, 1);
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            CustomerCapture customerCapture = new CustomerCapture();
            customerCapture.ShowDialog(this);
            InitForm();
        }

        private void InitForm()
        {

            var cust = CustomerRepository.LoadOrderList();

            dataGridView1.DataSource = cust;
            dataGridView1.Columns["CustomerId"].Visible = false;
        }

        private void LoadCustInfo_Click(object sender, EventArgs e)
        {
            InitForm();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var itemSlelected = dataGridView1.SelectedRows[0].DataBoundItem as Customer;
                txtName.Text = itemSlelected.Name.ToString();
                txtDOB.Text = itemSlelected.DateOfBirth.ToString();
                txtCountry.Text = itemSlelected.Country.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured");
                //throw ex;
            }
        }

        private void btNewOrder_Click(object sender, EventArgs e)
        {
            CustomerOrderCapture customerOrderCapture = new CustomerOrderCapture();
            customerOrderCapture.ShowDialog();
        }
    }
}
