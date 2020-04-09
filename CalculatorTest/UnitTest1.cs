using System;
using NUnit.Framework;
using CalculatorProject;

namespace CalculatorTest
{
    [TestFixture]
    public class UnitTest1
    {
        private Calculator cal;

        [SetUp]
        public void Setup()
        {
            cal = new Calculator();
        }

        [Test]
        public void OnePlusOneEqualTwo()
        {
            Assert.AreEqual(2, cal.Add(1, 1));
        }

        [Test]
        public void TwoPlusTwoEqualFour()
        {
            Assert.AreEqual(4, cal.Add(2, 2));
        }

        [Test]
        public void FourPlusOneEqualFive()
        {
            Assert.AreEqual(5, cal.Add(4, 1));
        }
    }
}
