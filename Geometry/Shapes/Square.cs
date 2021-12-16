
namespace Geometry.Shapes
{
    public class Square : Rectangle
    {
        private readonly double _A;

        public Square(double a) : base(a,a)
        {
            _A = a;
        }

        public new static string AreaFormula => "a * a";

        public new static string PerimeterFormula => "4 * a";

        public override string ToString()
        {
            return "Square{ " +
                "a = " + _A +
                '}';
        }
    }
}
