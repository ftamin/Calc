using MyCalculator;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCalculatorUnitTest
{
    [TestFixture]
    public class CalculatorUnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddTwoPositiveValues()
        {
            var calc = new Calc();
            var result = calc.Add(1, 2);

            Assert.AreEqual(result, 3); // result is as expected
            Assert.AreNotEqual(result, 1); // result is not equal to the first argument
            Assert.AreNotEqual(result, 2); // result is not equal to the second argument
            Assert.Greater(result, 0); // result must be always positive (the total of 2 positive numbers are always a positive number)
        }

        [Test]
        public void AddTwoNegativeValues()
        {
            var calc = new Calc();
            var result = calc.Add(-1, -2);

            Assert.AreEqual(result, -3); // result is as expected
            Assert.AreNotEqual(result, -1); // result is not equal to the first argument
            Assert.AreNotEqual(result, -2); // result is not equal to the second argument
            Assert.Less(result, 0); // result must be always negative (the total of 2 negative numbers are always a negative number)
        }
    }
}
