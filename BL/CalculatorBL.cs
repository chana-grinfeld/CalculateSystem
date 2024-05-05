namespace BL
{
    public class CalculatorBL
    {
        public static int Add(int num1, int num2)
        {
            return Convert.ToInt32(num1 + num2);
        }
        public static int Subtract(int num1, int num2)
        {
            return Convert.ToInt32(num1 - num2);
        }
        public static int Multiply(int num1, int num2)
        {
            return Convert.ToInt32(num1 * num2);
        }
        public static int Divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new ArgumentException("Cannot divide by zero.");
            }
            return num1 / num2;
        }
    }
}