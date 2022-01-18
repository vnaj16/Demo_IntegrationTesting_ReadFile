// See https://aka.ms/new-console-template for more information
using Demo_IntegrationTesting_ReadFile;

ICustomerRepository customerRepository = new CustomerRepository();
var list = customerRepository.GetCustomers();
foreach (var customer in list)
{
    Console.WriteLine($"{customer.FirstName} {customer.LastName} debe {customer.Debt} soles");
}
Console.WriteLine("Hello, World!");
