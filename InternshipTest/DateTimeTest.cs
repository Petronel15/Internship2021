using NUnit.Framework;
using System;
using Ziua2;

namespace InternshipTest
{
    public class DateTimeTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DateTimeToday()
        {
            //Arrange - adaugam toate resursele de care avem nevoie
            //var car = new Car();
            var today = new DateTimeType();

            //Act - apelam metoda pe care vrem sa o testam
            //car.AddService();
            var result = today.GetToday();


            //Assert - verificam daca rezultatul este cel asteptat
            //Assert.IsTrue(result == DateTime.Now);
            Assert.AreEqual(DateTime.Now, result);
            //Assert.That(result, Is.EqualTo(DateTime.Now));
        }

        [Test]
        public void DateTimeNow()
        {
            //Arrange - adaugam toate resursele de care avem nevoie
            var now = new DateTimeType();

            //Act - apelam metoda pe care vrem sa o testam
            var result = now.GetTime();


            //Assert - verificam daca rezultatul este cel asteptat
            //Assert.IsTrue(result == DateTime.Now);
            Assert.AreEqual("2021-05-11 10:35", result);
            //Assert.That(result, Is.EqualTo(DateTime.Now));

        }

        [Test]
        public void ParseDate()
        {
            //Arrange - adaugam toate resursele de care avem nevoie
            var now = new DateTimeType();

            //Act - apelam metoda pe care vrem sa o testam
            var result = now.ParseDate("2021-05-11");

            //Assert - verificam daca rezultatul este cel asteptat
            //Assert.IsTrue(result == DateTime.Today);
            //Assert.AreEqual(DateTime.Today, result);
            Assert.That(result, Is.EqualTo(DateTime.Today));
        }

        [Test]
        public void ParseDate2()
        {
            //Arrange - adaugam toate resursele de care avem nevoie
            var now = new DateTimeType();

            //Act - apelam metoda pe care vrem sa o testam
            var result = now.ParseDate2("05.11.2021");

            //Assert - verificam daca rezultatul este cel asteptat
            //Assert.IsTrue(result == DateTime.Today);
            //Assert.AreEqual("05.11.2021", result);
            Assert.That(result, Is.EqualTo(DateTime.Today));
        }
    }
}