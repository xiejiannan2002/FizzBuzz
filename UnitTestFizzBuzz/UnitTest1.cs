using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace UnitTestFizzBuzz
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetFizzBuzz()
        {
            Assert.AreEqual(Program.GetFizzBuzz(1), "1");
            Assert.AreEqual(Program.GetFizzBuzz(3), "Fizz");
            Assert.AreEqual(Program.GetFizzBuzz(5), "Buzz");
            Assert.AreEqual(Program.GetFizzBuzz(15), "FizzBuzz");
        }
    }
}
