using Xunit;
using FluentAssertions;
using Lebiru.Calculator;

namespace Lebiru.Calculator.Tests
{
    public class OperationTests
    {
        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(-1, -1, -2)]
        [InlineData(0, 0, 0)]
        [InlineData(100, 200, 300)]
        public void Addition_ReturnsCorrectResult(double num1, double num2, double expected)
        {
            var addition = new Addition();
            var result = addition.Execute(num1, num2);
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(-1, -1, 0)]
        [InlineData(0, 5, -5)]
        [InlineData(100, 50, 50)]
        public void Subtraction_ReturnsCorrectResult(double num1, double num2, double expected)
        {
            var subtraction = new Subtraction();
            var result = subtraction.Execute(num1, num2);
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(-1, -1, 1)]
        [InlineData(0, 5, 0)]
        [InlineData(10, 10, 100)]
        public void Multiplication_ReturnsCorrectResult(double num1, double num2, double expected)
        {
            var multiplication = new Multiplication();
            var result = multiplication.Execute(num1, num2);
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(-10, -2, 5)]
        [InlineData(0, 5, 0)]
        [InlineData(100, 4, 25)]
        public void Division_ReturnsCorrectResult(double num1, double num2, double expected)
        {
            var division = new Division();
            var result = division.Execute(num1, num2);
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(10, 0)]
        [InlineData(-5, 0)]
        public void Division_ThrowsExceptionOnDivideByZero(double num1, double num2)
        {
            var division = new Division();
            Action act = () => division.Execute(num1, num2);
            act.Should().Throw<DivideByZeroException>()
                .WithMessage("Division by zero is not allowed.");
        }
    }
}
