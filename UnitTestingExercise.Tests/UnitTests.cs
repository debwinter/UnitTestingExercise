using System;
using Xunit;
using UnitTestingExercise;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(100000, 99999, 1000000, 1199999)]
        [InlineData(5, -5, 1, 1)]
        [InlineData(-2, -3, -5, -10)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            Calculator calc = new Calculator();

            int actual = calc.Add(num1, num2, num3);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(0, 5, -5)]
        [InlineData(-5, -5, -10)]
        [InlineData(5, 0, 5)]
        [InlineData(5, 5, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(4, 4, 0)]
        [InlineData(9999999, 7777777, 2222222)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            Calculator calculator = new Calculator();

            int actual = calculator.Subtract(minuend, subtrahend);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(5, 5, 25)]
        [InlineData(0, 0, 0)]
        [InlineData(1000, 1000000, 1000000000)]
        [InlineData(-5, -5, 25)]
        [InlineData(5, -5, -25)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            Calculator calculator = new Calculator();

            int actual = calculator.Multiply(num1, num2);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(0, 0, 0)]
        [InlineData(1000000, 1000, 1000)]
        [InlineData(25, 5, 5)]
        [InlineData(25, -5, -5)]
        [InlineData(-25, -5, 5)]
        [InlineData(25, 25, 1)]
        public void DivideTest(int dividend, int divisor, int expected)
        {
            Calculator calculator = new Calculator();
            int actual = calculator.Divide(dividend, divisor);
            Assert.Equal(expected, actual);
        }

    }
}
