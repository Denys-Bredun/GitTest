namespace GitTest.AdditionalProject2
{
    public class GeometryMath
    {
        public static double CircleArea(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Радиус не может быть отрицательным");
            return Math.PI * radius * radius;
        }
        
        public static double CircleCircumference(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Радиус не может быть отрицательным");
            return 2 * Math.PI * radius;
        }
        
        public static double RectangleArea(double width, double height) => width * height;
        
        public static double RectanglePerimeter(double width, double height) => 2 * (width + height);
        
        public static double TriangleArea(double baseLength, double height) => (baseLength * height) / 2;
        
        public static double PythegoreanTheorem(double a, double b) => Math.Sqrt(a * a + b * b);
    }
}
