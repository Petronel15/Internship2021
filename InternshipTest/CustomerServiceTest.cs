using Core;
using NUnit.Framework;
using Service;
using System;
using Ziua2;

namespace InternshipTest
{
    public class CustomerServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateCustomerTest()
        {
            //Arrange - adaugam toate resursele de care avem nevoie
            var customer = new CustomerService();
            var customerCore = new Customer();

            customerCore.FirstName = "aaa";
            customerCore.LastName = "bbb";
            customerCore.StartDate = DateTime.Parse("11.11.1213");

            //Act - apelam metoda pe care vrem sa o testam
            customer.CreateCustomer(customerCore);


            //Assert - verificam daca rezultatul este cel asteptat
            //Assert.IsTrue(result == DateTime.Now);
            //Assert.AreEqual(DateTime.Now, result);
            //Assert.That(staticType2.name, Is.EqualTo("Test"));

        }


        [Test]
        public void GetCustomersTest()
        {
            //Arrange - adaugam toate resursele de care avem nevoie

            //Act - apelam metoda pe care vrem sa o testam

            //Assert - verificam daca rezultatul este cel asteptat
            //Assert.IsTrue(result == DateTime.Now);
            //Assert.AreEqual(DateTime.Now, result);
            //Assert.That(staticType2.name, Is.EqualTo("Test"));


        }
    }
}