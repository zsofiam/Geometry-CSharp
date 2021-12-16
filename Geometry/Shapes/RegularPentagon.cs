using System;

namespace Geometry.Shapes
{
    public class RegularPentagon : Shape
    {

        private readonly double _A;

        public RegularPentagon(double a)
        {
            _A = a;
        }

        public new static string AreaFormula => "a * a * sqrt(5*(5+2*sqrt(5))/4)";

        public new static string PerimeterFormula => "5 * a";

        public override double Area => _A * _A * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5)) / 4);

        public override double Perimeter => 5 * _A;

        public override string ToString()
        {
            return "RegularPentagon{ " +
                "a = " + _A +
                '}';
        }
    }
}
