using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
using Ziua2;

namespace InternshipTest
{
    public class DoubleTest
    {


        [Test]
        public void DoubleToString()
        {
            //Arrange - adaugam toate resursele de care avem nevoie
            
            var bancAcount = 20000.12345678;


            //Act - apelam metoda pe care vrem sa o testam
            //string result = ConvertDoubleToString.DoubleToString(20000.12345678);
            
            string result = bancAcount.ToString("F2");
            Console.WriteLine(CultureInfo.CurrentCulture);

            //Assert - verificam daca rezultatul este cel asteptat
            //Assert.IsTrue(result == DateTime.Now);
            //Assert.AreEqual(DateTime.Now, result);
            Assert.That(result, Is.EqualTo("20000.12"));
        }

        [Test]
        public void DoubleToString2()
        {
            //Arrange - adaugam toate resursele de care avem nevoie
            var bankAcount = 20000.12345678;

            //Act - apelam metoda pe care vrem sa o testam
            string result = "Your bank account is " + bankAcount.ToString("F2");
            string result2 = $"Your bank account is {bankAcount:F2}";
            string result3 = string.Format("Your bank account is {0:F2}", bankAcount);
            string result4 = string.Format("Your bank account is {0,8:F2}", 200.12);

            //Console.WriteLine(CultureInfo.CurrentCulture);

            //Assert - verificam daca rezultatul este cel asteptat
            //Assert.IsTrue(result == DateTime.Now);
            //Assert.AreEqual(DateTime.Now, result);
            Assert.That(result4, Is.EqualTo("Your bank account is   200.12"));
        }

        [Test]
        public void DebugList()
        {
            //Arrange - adaugam toate resursele de care avem nevoie
            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

            //Act - apelam metoda pe care vrem sa o testam
            foreach(var number in numbers)
            {
                
            }
            //Assert - verificam daca rezultatul este cel asteptat
            //Assert.IsTrue(result == DateTime.Now);
            //Assert.AreEqual(DateTime.Now, result);
            //Assert.That(result4, Is.EqualTo("Your bank account is   200.12"));
        }
    }
}