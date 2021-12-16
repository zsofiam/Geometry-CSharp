
namespace Geometry.Shapes
{
    public class Rectangle : Shape
    {
        private readonly double _A;
        private readonly double _B;

        public Rectangle(double a, double b)
        {
            _A = a;
            _B = b;
        }

        public new static string AreaFormula => "a * b";

        public new static string PerimeterFormula => "2 * (a + b)";

        public override double Area => _A * _B;

        public override double Perimeter => _A + _B;

        public override string ToString()
        {
            return "Rectangle{ " +
                "a = " + _A +
                ", b = " + _B +
                '}';
        }
    }
}
