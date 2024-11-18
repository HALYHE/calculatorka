using calculatorka;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void Add_ValidInputs_ReturnsCorrectResult()
        {
            double result = calculator.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Subtract_ValidInputs_ReturnsCorrectResult()
        {
            double result = calculator.Subtract(5, 3);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Multiply_ValidInputs_ReturnsCorrectResult()
        {
            double result = calculator.Multiply(2, 3);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_DivideByZero_ThrowsDivideByZeroException()
        {
            calculator.Divide(5, 0);
        }

        [TestMethod]
        public void Divide_ValidInputs_ReturnsCorrectResult()
        {
            double result = calculator.Divide(10, 2);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Divide_ValidInputsWithRounding_ReturnsCorrectResult()
        {
            double result = calculator.Divide(5, 3);
            Assert.AreEqual(1.67, result, 0.01);
        }
    }
}
