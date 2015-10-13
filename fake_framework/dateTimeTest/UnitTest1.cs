using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using datatimenow;
using Microsoft.QualityTools.Testing.Fakes;

namespace dateTimeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using(ShimsContext.Create())
            {
                System.Fakes.ShimDateTime.NowGet = () =>
                    {
                        return new DateTime(2, 10, 2014);
                    };
                NowDate expected = new NowDate { date = new DateTime(2014, 10, 14) };
                NowDate actual = new NowDate{date = new DateTime(2014, 10, 14)};
                Assert.AreEqual(expected.date, actual.date);
            }
        }
    }
}
