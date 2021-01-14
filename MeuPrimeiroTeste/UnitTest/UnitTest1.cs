using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;

namespace UnitTest
{
    [TestClass]
    public class StringAssertClassTest
    {
        [TestMethod]
        public void containsTest()
        {
            string str1 = "Deivide Silva";
            string str2 = "Silva";

            StringAssert.Contains(str1, str2);
        }

        [TestMethod]
        public void StartWithTest()
        {
            string str1 = "Todos com Caixa Alta";
            string str2 = "Todos com Caixa";

            StringAssert.StartsWith(str1, str2);

        }

        [TestMethod]
        public void IsAllLowerCaseTest()
        {
            Regex reg = new Regex(@"^([^A-Z])+$");

            StringAssert.Matches("todos caixa",reg);
        }

        [TestMethod]
        public void IsNotLowerCaseTest()
        {
            Regex reg = new Regex(@"^([^A-Z])+$");

            StringAssert.DoesNotMatch("Todos caixa", reg);
        }
    }
}
