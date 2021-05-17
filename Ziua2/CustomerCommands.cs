using Core;
using Core.Exceptions;
using Service;
using System;
using System.Collections.Generic;
using System.Text;


namespace Ziua2
{
    public class CustomerCommands
    {
        private readonly CustomerService customerService; 
        public CustomerCommands()
        {
            customerService = new CustomerService();
        }


        public void ShowCustomers()
        {
            var list = customerService.GetCustomers();

            Console.WriteLine("------------------------------------------"); //42
            Console.WriteLine("| Name                | Start date       |");
            foreach (var customer in list)
            {
                var name = $"{customer.FirstName}, {customer.LastName}";
                Console.WriteLine($"| { name,-20}| { customer.StartDate,-15:d}  |");
            }
        }

        public void AddCustomers()
        {
            Console.WriteLine("Enter the customer first name");
            var firstName = Console.ReadLine();

            Console.WriteLine("Enter the customer last name");
            var lastName = Console.ReadLine();

            Console.WriteLine("Enter the customer start date");
            var startDate = Convert.ToDateTime(Console.ReadLine());

            var customer = new Customer()
            {
                FirstName = firstName,
                LastName = lastName,
                StartDate = startDate
            };

            customerService.customerCreated += CustomerCreatedMessage;

            try
            {
                customerService.CreateCustomer(customer);

            }

            catch (DuplicateItemException ex)
            {
                Console.WriteLine("Duplicate item exception: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                customerService.customerCreated -= CustomerCreatedMessage;
            }

        }

        static void CustomerCreatedMessage(object sender, EventArgs e)
        {
            Console.WriteLine("Customer was created");
        }
    }
}
