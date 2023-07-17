using System.Data.SqlClient;

namespace AnyCompany
{
    public class OrderService
    {
        private readonly OrderRepository orderRepository = new OrderRepository();
        private static string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Customers;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
        public bool PlaceOrder(Order order, int customerId)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
                    


            SqlCommand command = new SqlCommand("SELECT count(CustomerId) FROM Customer",connection);
            int i = int.Parse(command.ExecuteScalar().ToString());
            //var reader = command.ExecuteScalar();
            
            Customer customer = CustomerRepository.Load(customerId);
            order.OrderId = i++;
            
            if (order.Amount == 0)
                return false;

            if (customer.Country == "UK")
                order.VAT = 0.2d;
            else
                order.VAT = 0;

            orderRepository.Save(order);

            return true;
        }
    }
}
