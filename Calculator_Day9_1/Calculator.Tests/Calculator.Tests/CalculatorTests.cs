using NUnit.Framework;
using System;
using Calculator;

namespace Calculator.Tests
{
    public class Tests
    {
        private CalculatorMain calculator;
        [SetUp]
        public void Setup()
        {
            calculator = new CalculatorMain();
        }

        [Test]
        public void Add_Test()
        {
            double result = calculator.Add(7, 3);
            Assert.AreEqual(10,result);
        }
        [Test]
        public void Sub_Test()
        {
            double result = calculator.Subtract(7, 3);
            Assert.AreEqual(4, result);
        }
        [Test]
        public void Mul_Test()
        {
            double result = calculator.Multiply(7, 3);
            Assert.AreEqual(21, result);
        }
        [Test]
        public void Div_test()
        {
            double result = calculator.Divide(9, 3);
            Assert.AreEqual(3, result);
        }
        [Test]
        public void Divide_ByZero()
        {
            try
            {
                calculator.Divide(10, 0);
                Assert.Fail("Expected exception was not thrown.");
            }
            catch (DivideByZeroException)
            {
                Assert.Pass();
            }
        }
    }
}
