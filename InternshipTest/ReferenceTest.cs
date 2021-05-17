using Newtonsoft.Json;
using NUnit.Framework;
using System;
using Ziua2;

namespace InternshipTest
{
    public class ReferenceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReferenceAndValueTest()
        {
            //Arrange - adaugam toate resursele de care avem nevoie
            DateTimeType object1 = new DateTimeType(); // 1:pointer catre obiect  2: obiectul cu proprietatile
            DateTimeType object2 = new DateTimeType(); // 3:pointer catre obiect  4: obiectul cu proprietatile

            //Act - apelam metoda pe care vrem sa o testam
            object2 = object1;  //val 1 va merge in val de la 3 =>2         1=>2

            object2.datetime2 = DateTime.Today; //modificam obiectul din spatiul de memorie 2    3=>2
            //Assert - verificam daca rezultatul este cel asteptat
            //Assert.IsTrue(result == DateTime.Now);
            //Assert.AreEqual(DateTime.Now, result);
            Assert.That(object2.datetime2, Is.EqualTo(DateTime.Today));
            Assert.That(object1.datetime2, Is.EqualTo(DateTime.Today));
        }

        [Test]
        public void ReferenceAndValueTest2()
        {
            //Arrange - adaugam toate resursele de care avem nevoie
            DateTimeType object1 = new DateTimeType(); // 1:pointer catre obiect  2: obiectul cu proprietatile
            DateTimeType object2 = new DateTimeType(); // 3:pointer catre obiect  4: obiectul cu proprietatile

            //Act - apelam metoda pe care vrem sa o testam
            //object2 = object1;  //val 1 va merge in val de la 3 =>2         1=>2
            object2 = object1.Clone(); // 3:pointer catre obiect 5
            object2.datetime2 = DateTime.Today; //modificam obiectul din spatiul de memorie 2    3=>2
            //Assert - verificam daca rezultatul este cel asteptat
            //Assert.IsTrue(result == DateTime.Now);
            //Assert.AreEqual(DateTime.Now, result);
            Assert.That(object2.datetime2, Is.EqualTo(DateTime.Today));
            Assert.That(object1.datetime2, Is.EqualTo(DateTime.MinValue));
        }
        [Test]
        public void ReferenceAndValueTest3()
        {
            //Arrange - adaugam toate resursele de care avem nevoie
            int value1 = 3;
            int value2 = 4;

            //Act - apelam metoda pe care vrem sa o testam
            value2 = value1;
           
            Assert.That(value2, Is.EqualTo(3));
        }

        [Test]
        public void ReferenceAndValueTest4()
        {
            //Arrange - adaugam toate resursele de care avem nevoie
            DateTimeType object1 = new DateTimeType();

            //Act - apelam metoda pe care vrem sa o testam
            DateTimeUtil.SetDatetime2Today(object1);

            //Assert
            Assert.That(object1.datetime2, Is.EqualTo(DateTime.Today));
        }

        [Test]
        public void ReferenceAndValueTest5()
        {
            //Arrange - adaugam toate resursele de care avem nevoie
            int value1 = 3;

            //Act - apelam metoda pe care vrem sa o testam
            DateTimeUtil.SetInt(ref value1);

            //Assert
            Assert.That(value1, Is.EqualTo(4));
        }

        [Test]
        public void ReferenceAndValueTest6()
        {
            //Arrange - adaugam toate resursele de care avem nevoie
            int value1;

            //Act - apelam metoda pe care vrem sa o testam
            DateTimeUtil.TestOut(out value1);

            //Assert
            Assert.That(value1, Is.EqualTo(4));
        }

        [Test]
        public void ReferenceAndValueTest7()
        {
            //Arrange - adaugam toate resursele de care avem nevoie
            DateTimeType object1 = new DateTimeType();

            //Act - apelam metoda pe care vrem sa o testam
            DateTimeUtil.SetWithNewInstanceDatetime2Today(ref object1);

            //Assert
            Assert.That(object1.datetime2, Is.EqualTo(DateTime.Today));
        }

        [Test]
        public void ReferenceAndValueTest8()
        {
            //Arrange - adaugam toate resursele de care avem nevoie
            DateTimeType object1 = new DateTimeType();
            object1.datetime2 = DateTime.Now;

            //Act - apelam metoda pe care vrem sa o testam
            string json = JsonConvert.SerializeObject(object1);
            var object2 = JsonConvert.DeserializeObject<DateTimeType>(json);

            //Assert
            Assert.That(object1.datetime2, Is.EqualTo(object2.datetime2));
        }

        [Test]
        public void ReferenceAndValueTest9()
        {
            //Arrange - adaugam toate resursele de care avem nevoie
            DateTimeType object1 = null;
            string abc = null;
            Nullable<int> value = null;
            int? value2 = null;

            //Act - apelam metoda pe care vrem sa o testam
            if (value2.HasValue)
                value2.Value.ToString();
            var result = value2?.ToString();      // result = null
            var result2 = value2 ?? 2;   // daca value2 este null -> result2=2
            if (value2 == null) result2 = 2;
            //Assert
            
        }
    }
}