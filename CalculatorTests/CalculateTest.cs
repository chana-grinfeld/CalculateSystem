using Xunit;
using BL;

namespace CalculatorTests
{
    public class CalculateTest
    {
        [Theory]
        [Fact]
        public bool TestAdd()
        {
            // Arrange
            int num1 = 5;
            int num2 = 3;

            // Act
            int result = CalculatorBL.Add(num1, num2);

            // Assert
            if (result == 8)
            {
                return true;
            }
            return false;
        }

        [Fact]
        public bool TestSubtract()
        {
            // Arrange
            int num1 = 10;
            int num2 = 4;

            // Act
            int result = CalculatorBL.Subtract(num1, num2);

            // Assert
            if (result == 6)
            {
                return true;
            }
            return false;
        }

        [Fact]
        public bool TestMultiply()
        {
            // Arrange
            int num1 = 7;
            int num2 = 2;

            // Act
            int result = CalculatorBL.Multiply(num1, num2);

            // Assert
            if (result == 14)
            {
                return true;
            }
            return false;
        }

        [Fact]
        public bool TestDivide()
        {
            // Arrange
            int num1 = 20;
            int num2 = 5;

            // Act
            int result = CalculatorBL.Divide(num1, num2);

            // Assert
            if (result == 25)
            {
                return true;
            }
            return false;
        }
    }
}