using MeuPrimeiroTeste;
using MeuPrimeiroTeste.PersonClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    
    [TestClass]
    public class FileProcessTest
    {
        [TestMethod]
        [Priority(0)]
        public void FileNameExists()
        {
            FileProcess fp = new FileProcess();
            bool fromCall;

            fromCall = fp.FileExists(@"C:\Windows\regedit.exe");

            Assert.IsTrue(fromCall);
        }

        [TestMethod]
        [Priority(1)]
        public void FileNameDoesNotExists()
        {
            FileProcess fp = new FileProcess();
            bool fromCall;

            fromCall = fp.FileExists(@"C:\regedit.exe");

            Assert.IsFalse(fromCall);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameNullOrEmpty_ThrowsArgumentNullException()
        {
            FileProcess fp = new FileProcess();
            fp.FileExists("");
           
        }

        [TestMethod]
        [Priority(1)]
        public void FileNameNullOrEmpty_ThrowsArgumentNullException_UsingTryCatch()
        {
            FileProcess fp = new FileProcess();

            try
            {
                fp.FileExists("");
            }
            catch (ArgumentException)
            {

                return;
            }

            Assert.Fail("Fail expected!!!");
        }
        [TestMethod]
        public void AreSameTest()
        {
            FileProcess x = new FileProcess();
            FileProcess y = x;

            Assert.AreSame(x, y);
        }

        [TestMethod]
        public void AreNotSameTest()
        {
            FileProcess x = new FileProcess();
            FileProcess y = new FileProcess();

            Assert.AreNotSame(x,y);
        }

        #region IsInstanceOfType Test
        [TestMethod]
        public void IsInstanceOfTypeTest()
        {
            PersonManager mgr = new PersonManager();
            Person person;

            person = mgr.CreatePerson("Deivide", "Silva", true);

            Assert.IsInstanceOfType(person, typeof(Supervisor));
        }

        [TestMethod]
        public void IsNull()
        {
            PersonManager mgr = new PersonManager();
            Person person;

            person = mgr.CreatePerson("", "Silva", true);

            Assert.IsNull(person);
        }
        #endregion
    }
}
