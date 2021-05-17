using Core;
using Core.Exceptions;
using System;
using System.Collections.Generic;

namespace Service
{
    public delegate int customerCreatedCallBack(string customerName);
    // public delegate void customerCreatedDelegate(object sender, EventArgs args); 

    public class CustomerService
    {
        public event EventHandler customerCreated;  // public event customerCreatedDelegate customerCreated;

        private readonly List<Customer> customerRepository;
        public CustomerService()
        {
            customerRepository = new List<Customer>();
        }

        public void CreateCustomer(Customer customer) // int metoda(int)
        {
            customerCreatedCallBack callBack = customerCreatedHandler;
            callBack(customer.FirstName);

            if (customer == null) throw new ArgumentException("Name can't be null", nameof(customer)); // "customer"
            
            CheckCustomerAlreadyExists(customer);
            if (CustomerAlreadyExists(customer))
            {
                throw new DuplicateItemException("User is already exists");
            }
            customerRepository.Add(customer);
            
            if (customerCreated != null)
            {
                customerCreated(this, new EventArgs());  //daca cineva e abonat, vom trimite mesaj
            }
        }

        public List<Customer> GetCustomers()
        {
            return customerRepository;
        }

        private int customerCreatedHandler(string customerName)
        {
            return 0;
        }

        private void CheckCustomerAlreadyExists(Customer customer)
        {
            foreach (var dbCustomer in customerRepository)
            {
                if (customer.FirstName == dbCustomer.FirstName && customer.LastName == dbCustomer.LastName)
                    throw new DuplicateItemException("User is already in database");
            }

        }
        private bool CustomerAlreadyExists(Customer customer)
        {
            foreach (var dbCustomer in customerRepository)
            {
                if (customer.FirstName == dbCustomer.FirstName && customer.LastName == dbCustomer.LastName)
                    return true;
            }
            return false;
        }
    }
}
