using Demo_IntegrationTesting_Database.Models;

namespace Demo_IntegrationTesting_Database
{
    public interface ICustomerRepository
    {
        public List<Customer> GetCustomers();
    }
}
