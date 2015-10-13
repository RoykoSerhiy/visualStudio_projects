using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using fake_framework;
using Microsoft.QualityTools.Testing.Fakes;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (ShimsContext.Create())
            {
                System.IO.Fakes.ShimStreamReader.ConstructorString = (@this, path) => { };
                System.IO.Fakes.ShimStreamReader.AllInstances.ReadToEnd = sr =>
                    {
                        return "23.09.2014 12:45:37 message 1\n23.09.2014 12:45:37 message 2\n23.09.2014 12:45:38 message 3";
                    };
                LogMessage[] expected = 
                {
                    new LogMessage {Time = DateTime.Parse("23.09.2014 12:45:37"), Message = "message 1"},
                    new LogMessage {Time = DateTime.Parse("23.09.2014 12:45:37"), Message = "message 2"},
                    new LogMessage {Time = DateTime.Parse("23.09.2014 12:45:38"), Message = "message 3"}
                };
                LogMessage[] actual = LogParser.Parse("qwerty");
                Assert.AreEqual(expected.Length, actual.Length);
                for (int i = 0; i < actual.Length; ++i)
                {
                    Assert.AreEqual(expected[i].Time, actual[i].Time);
                    Assert.AreEqual(expected[i].Message, actual[i].Message);

                }
            }
        }
    }
}
