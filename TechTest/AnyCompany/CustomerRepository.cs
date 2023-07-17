using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace AnyCompany
{
    public static class CustomerRepository
    {
        private static string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Customers;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";

        public static Customer Load(int customerId)
        {
            Customer customer = new Customer();

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Customer WHERE CustomerId = " + customerId,
                connection);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                customer.Name = reader["Name"].ToString();
                customer.DateOfBirth = DateTime.Parse(reader["DateOfBirth"].ToString());
                customer.Country = reader["Country"].ToString();
            }

            connection.Close();

            return customer;
        }

        public static List<Customer> LoadOrderList()
        {
            List<Customer> customerlist = new List<Customer>();
            

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Customer",
                connection);

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                Customer customer = new Customer();
                customer.CustomerId = int.Parse(reader["CustomerId"].ToString());
                customer.Name = reader["Name"].ToString();
                customer.DateOfBirth = DateTime.Parse(reader["DateOfBirth"].ToString());
                customer.Country = reader["Country"].ToString();
                customerlist.Add(customer);
            }

            connection.Close();

            return customerlist;
        }


        public static List<Customer> LoadCustOrderList(int customerId)
        {
            List<Customer> customerlist = new List<Customer>();


            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT TOP (1000) [Name],[Country] ,[DateOfbirth],[Amount],[OrderDescription] ,[Vat] FROM[Customers].[dbo].[vwCustomerLinkedOrders] Where CustomerId = " + customerId,
                connection);

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                Customer customer = new Customer();
                customer.CustomerId = int.Parse(reader["CustomerId"].ToString());
                customer.Name = reader["Name"].ToString();
                customer.DateOfBirth = DateTime.Parse(reader["DateOfBirth"].ToString());
                customer.Country = reader["Country"].ToString();
                customerlist.Add(customer);
            }

            connection.Close();

            return customerlist;
        }

        public static void Save(Customer customer, int rowID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("INSERT INTO Customer VALUES (@CustomerId, @Name, @DateOfBirth,@Country)", connection);
            String strDateFormat = "yyyy-MM-dd";
            var dt = Convert.ToDateTime(customer.DateOfBirth.ToString());
            if (customer != null)
            {
                command.Parameters.AddWithValue("@CustomerId", rowID);
                command.Parameters.AddWithValue("@Name", customer.Name);          
                command.Parameters.AddWithValue("@DateOfBirth", dt);
                command.Parameters.AddWithValue("@Country", customer.Country);
                command.ExecuteNonQuery();
            }          

            connection.Close();
        }
    }
}
