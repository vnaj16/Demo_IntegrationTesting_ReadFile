using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_IntegrationTesting_ReadFile
{
    public interface ICustomerRepository
    {
        public List<Customer> GetCustomers();
    }
}
