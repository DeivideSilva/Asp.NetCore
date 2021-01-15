using MeuPrimeiroTeste.PersonClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class CollectionAssertClass
    {
        [TestMethod]
        public void AreCollectionEqualFailBecauseNoCompareTest()
        {
            PersonManager PerMgr = new PersonManager();
            List<Person> peopleExpected = new List<Person>();
            List<Person> peopleActual = new List<Person>();

            peopleExpected.Add(new Person() { FirstName = "Deivide", LastName = "Silva" });
            peopleExpected.Add(new Person() { FirstName = "Julia", LastName = "Gabriella" });
            peopleExpected.Add(new Person() { FirstName = "July", LastName = "Lopes"});

            //You shall not pass
            peopleActual = PerMgr.GetPeople();

            CollectionAssert.AreEqual(peopleExpected,peopleActual);
        }

        [TestMethod]
        public void AreCollectionEqualWithCompareTest()
        {
            PersonManager PerMgr = new PersonManager();
            List<Person> peopleExpected = new List<Person>();
            List<Person> peopleActual = new List<Person>();

            peopleExpected.Add(new Person() { FirstName = "Deivide", LastName = "Silva" });
            peopleExpected.Add(new Person() { FirstName = "Julia", LastName = "Gabriella" });
            peopleExpected.Add(new Person() { FirstName = "July", LastName = "Lopes" });

            peopleActual = PerMgr.GetPeople();

            CollectionAssert.AreEqual(peopleExpected, peopleActual,
                    Comparer<Person>.Create((x,y) =>
                           x.FirstName == y.FirstName && x.LastName == y.LastName ? 0 : 1));
        }

        [TestMethod]
        public void AreCollectionEquivalentTest()
        {
            PersonManager PerMgr = new PersonManager();
            List<Person> peopleExpected = new List<Person>();
            List<Person> peopleActual = new List<Person>();

            peopleActual = PerMgr.GetPeople();

            peopleExpected.Add(peopleActual[1]);
            peopleExpected.Add(peopleActual[2]);
            peopleExpected.Add(peopleActual[0]);

            CollectionAssert.AreEquivalent(peopleExpected, peopleActual);
        }
    }
}
