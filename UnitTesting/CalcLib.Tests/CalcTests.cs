using CalcLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcLib.Tests
{
    [TestClass]
    public class CalcTests
    {
        private const int X = 40;
        private const int Y = 20;
        [TestMethod]
        public void Sum_20and40_60returned()
        {
           
            const int expected = 60;

            var calc = new Calc();
            var actual = calc.Sum(X, Y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SubtractionTest()
        {

            const int expected = 20;

            var calc = new Calc();
            var actual = calc.Subtraction(X, Y);

            Assert.AreEqual(expected, actual);
        }
    }
}
