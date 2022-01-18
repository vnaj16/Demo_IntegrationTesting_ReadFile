using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_IntegrationTesting_ReadFile
{
    public class CustomerRepository : ICustomerRepository
    {
        public List<Customer> GetCustomers()
        {
            List<Customer> response = new List<Customer>();
            var lines = File.ReadAllLines(@"C:\customer.txt");

            foreach (var line in lines)
            {
                var fields = line.Split(',');
                response.Add(new Customer()
                {
                    Id = Convert.ToInt32(fields[0]),
                    FirstName = fields[1],
                    LastName = fields[2],
                    Debt = Convert.ToInt32(fields[3])
                });
            }
            return response;
        }
    }
}
