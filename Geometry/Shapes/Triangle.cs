using System;

namespace Geometry.Shapes
{
    public class Triangle : Shape
    {
        private readonly double _A;
        private readonly double _B;
        private readonly double _C;

        public Triangle(double a, double b, double c)
        {
            _A = a;
            _B = b;
            _C = c;
        }

        public new static string AreaFormula => "sqrt(s*(s-a)*(s-b)*(s-c)) where s = (a + b + c)/2";

        public new static string PerimeterFormula => "a + b + c";

        /// <inheritdoc/>
        public override double Perimeter => _A + _B + _C;

        /// <inheritdoc />
        public override double Area => Math.Sqrt((_A + _B + _C) / 2 * ((_A + _B + _C) / 2 - _A)
            * ((_A + _B + _C) / 2 - _B) * ((_A + _B + _C) / 2 - _C));

        public override string ToString()
        {
            return "Triangle{ " +
                "a = " + _A +
                ", b = " + _B +
                ", c = " + _C +
                '}';
        }

    }
}
