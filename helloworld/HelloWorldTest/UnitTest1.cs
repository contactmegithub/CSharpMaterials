using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using helloworld;
namespace HelloWorldTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program _Program = new Program();

            string FirstName = "Tim";
            string LastName = "Alex";
            string output = $"{FirstName} {LastName}";
            var result = _Program.ConcatName(FirstName, LastName);

            Assert.AreEqual(output, result);
        }
    }
}
