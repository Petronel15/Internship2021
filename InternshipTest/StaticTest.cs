using NUnit.Framework;
using System;
using Ziua2;

namespace InternshipTest
{
    public class StaticTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void StaticTest1()
        {
            //Arrange - adaugam toate resursele de care avem nevoie
            
            var staticType = new StaticType();
            staticType.name = "Octavian";
            StaticType.staticName = "Cosmin";


            //Act - apelam metoda pe care vrem sa o testam
            var staticType2 = new StaticType();


            //Assert - verificam daca rezultatul este cel asteptat
            //Assert.IsTrue(result == DateTime.Now);
            //Assert.AreEqual(DateTime.Now, result);
            Assert.That(staticType2.name, Is.EqualTo("Test"));
        }
    }
}