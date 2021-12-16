using Geometry.Shapes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Geometry.Containers
{
    public class ShapeCollection
    {
        private readonly List<Shape> Shapes = new();

        public void AddShape(Shape shape)
        {
            Shapes.Add(shape);
        }

        public string GetShapesTable()
        {
            int id = 0;
            StringBuilder sb = new("/------------------------------------------------------------------------------------------------------------------------------------\\\n" +
                    "| ID|                Class|                                toString|                       Perimeter|                            Area|\n" +
                    "|---|---------------------|----------------------------------------|--------------------------------|--------------------------------|\n");
            
            if(Shapes!=null && Shapes.FirstOrDefault() != null)
            {
                foreach (Shape shape in Shapes)
            {
                string perimeter = String.Format("{0:.00}", shape.Perimeter);
                string area = String.Format("{0:.00}", shape.Area);
                sb.Append(String.Format("|{0,3}|{1,21}|{2,40}|{3,32}|{4,32}|\n", id, shape.GetType().Name, shape.ToString(), perimeter, area));
                id++;
            }
            }
            sb.Append("\\------------------------------------------------------------------------------------------------------------------------------------/\n");

            return sb.ToString();
        }

        public Shape GetLargestShapeByPerimeter()
        {
            double largestPerimeter = 0;
            Shape shapeWithLargest = null;
            foreach (Shape shape in Shapes)
            {
                double currentPerimeter = shape.Perimeter;
                if (currentPerimeter > largestPerimeter)
                {
                    largestPerimeter = currentPerimeter;
                    shapeWithLargest = shape;
                }
            }
            return shapeWithLargest;
        }

        public Shape GetLargestShapeByArea()
        {
            double largest = 0;
            Shape shapeWithLargest = null;
            foreach (Shape shape in Shapes)
            {
                double currentArea = shape.Area;
                if (currentArea > largest)
                {
                    largest = currentArea;
                    shapeWithLargest = shape;
                }
            }
            return shapeWithLargest;
        }

    }
}
