using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace CircleTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double r = 4;
            double expected = 50.24;
            double ex = 25.12;
            Circle rc = new Circle();
            double actual = rc.Square(r);
            double ac = rc.circle(r);
            Assert.AreEqual(expected, actual, " Площадь рассчитывается не правильно.");
            Assert.AreEqual(ex, ac, " Окружность рассчитывается не правильно.");

        }
    }
}
