// CalculatorTests.cs
using CalculatorLibrary;
using NUnit.Framework;
using System;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_ShouldReturnCorrectResult_WhenValidInputsAreGiven()
        {
            // Arrange
            double a = 5, b = 3;

            // Act
            double result = _calculator.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(8));  // Using constraint model
        }

        [Test]
        public void Subtract_ShouldReturnCorrectResult_WhenValidInputsAreGiven()
        {
            // Arrange
            double a = 5, b = 3;

            // Act
            double result = _calculator.Subtract(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(2));  // Using constraint model
        }

        [Test]
        public void Multiply_ShouldReturnCorrectResult_WhenValidInputsAreGiven()
        {
            // Arrange
            double a = 5, b = 3;

            // Act
            double result = _calculator.Multiply(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(15)); // Using constraint model
        }

        [Test]
        public void Divide_ShouldReturnCorrectResult_WhenValidInputsAreGiven()
        {
            // Arrange
            double a = 6, b = 3;

            // Act
            double result = _calculator.Divide(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(2));  // Using constraint model
        }

        [Test]
        public void Divide_ShouldThrowDivideByZeroException_WhenDividingByZero()
        {
            // Arrange
            double a = 5, b = 0;

            // Act & Assert
            Assert.That(() => _calculator.Divide(a, b),
                        Throws.TypeOf<DivideByZeroException>().With.Message.Contains("Cannot divide by zero."));
        }

        [Test]
        public void Add_ShouldReturnCorrectResult_WhenAddingZero()
        {
            // Arrange
            double a = 0, b = 5;

            // Act
            double result = _calculator.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(5));  // Using constraint model
        }
    }
}
