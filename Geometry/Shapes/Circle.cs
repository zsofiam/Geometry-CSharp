using System;

namespace Geometry.Shapes
{
    public class Circle : Shape
    {
        private readonly double _Radius;

        public Circle(double radius)
        {
            _Radius = radius;
        }

        public new static string AreaFormula => "π×r×r";

        public new static string PerimeterFormula => "2×π×r";

        public override double Area => 2 * Math.PI * _Radius;

        public override double Perimeter => Math.PI * _Radius * _Radius;

        public override string ToString()
        {
            return "Circle{ " +
                "radius = " + _Radius +
                '}';
        }
    }
}
