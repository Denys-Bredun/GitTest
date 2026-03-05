namespace GitTest.AdditionalProject1
{
    public class BasicMath
    {
        public static double Add(double a, double b) => a + b;

        public static double Subtract(double a, double b) => a - b;

        public static double Multiply(double a, double b) => a * b;

        public static double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Деление на ноль невозможно");
            return a / b;
        }

        public static double Power(double baseNumber, double exponent) => Math.Pow(baseNumber, exponent);

        public static double SquareRoot(double number)
        {
            if (number < 0)
                throw new ArgumentException("Невозможно извлечь квадратный корень из отрицательного числа");
            return Math.Sqrt(number);
        }
    }
}
