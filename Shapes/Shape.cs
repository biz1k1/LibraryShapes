using LibraryShapes.exception;
using LibraryShapes.interfaces;

namespace LibraryShapes
{

    public class Triangle : IShape
    {
        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }
        private bool rightTriangle;
        // не знаю где еще будет уместнее вызвать CheckRightTriangle(), кроме как конструктора 
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
            CheckRightTriangle();
        }
        public double Area()
        {
            if (A < 0 | B < 0 | C < 0)
            {
                throw new NegativeNumberException();
            }
            double perimetr = (A + B + C) / 2;
            double square = Math.Sqrt((perimetr * (perimetr - A) * (perimetr - B) * (perimetr - C)));
            return square;
        }
        //прямоугольном треугольнике квадрат длины гипотенузы равен сумме квадратов длин катетов. 
        public bool CheckRightTriangle()
        {
            var aSide = Math.Sqrt(Math.Pow(C, 2) - Math.Pow(B, 2));
            var bSide = Math.Sqrt(Math.Pow(C, 2) - Math.Pow(A, 2));
            var cSide = Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));
            if (A > B | A > C)
            {
            }
            if (aSide + bSide == cSide)
            {
                rightTriangle = true;
            }
            return true;
        }
    }
    public class Circle : IShape
    {
        private double Radius { get; set; }
        const double Pi = 3.14;
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area()
        {
            if (Radius < 0)
            {
                throw new NegativeNumberException();
            }
            return Radius * Radius * Pi;
        }
    }
    public class ShapeHandler : IShapeHandler
    {
        public double CalculateArea(IShape shape)
        {
            double result = Math.Round(shape.Area());
            return result;
        }
    }
}