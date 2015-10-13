using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using testing;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a = 3;
            double b = 3.5;
            double expected = 6.5;
            double actual = testing.Program.Calc(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
