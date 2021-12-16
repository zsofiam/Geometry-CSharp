using System;

namespace Geometry.Shapes
{
    public class EquilateralTriangle : Triangle
    {
        private double _A;

        public EquilateralTriangle(double a) : base(a, a, a)
        {
            _A = a;
        }

        public new static string AreaFormula => "sqrt(3)/4 * a * a";

        public new static string PerimeterFormula => "3 * a";

        public override double Area => Math.Pow(_A, 2) * Math.Sqrt(3) / 4;

        public override double Perimeter => 3 * _A;

        public override string ToString()
        {
            return "Equilateral triangle{ " +
                "a = " + _A +
                '}';
        }
    }
}
