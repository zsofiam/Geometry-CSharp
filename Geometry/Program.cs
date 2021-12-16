using Geometry.Containers;
using Geometry.Shapes;
using System;

namespace Geometry
{
    public static class Program
    {
        static readonly ShapeCollection shapeCollection = new();
        public static void Main(string[] args)
            {
                bool isRunning = true;
                int option;
                while (isRunning)
                {
                    Console.WriteLine(
                        "Choose between the options: \n" +
                                "1 Add Shape\n" +
                                "2 Show All Shapes\n" +
                                "3 Show Shape With Largest Perimeter\n" +
                                "4 Show Shape With Largest Area\n" +
                                "5 Show Formulas\n" +
                                "0 Exit\n");

                    ConsoleKeyInfo userInput = Console.ReadKey();

                    if (char.IsDigit(userInput.KeyChar))
                    {
                        option = int.Parse(userInput.KeyChar.ToString());
                    }
                    else
                    {
                        option = -1;
                    }

                    switch (option)
                    {
                        case -1:
                            Console.WriteLine("Please try again!");
                            break;
                        case 1:
                            AddShape();
                            break;
                        case 2:
                            ShowAllShapes();
                            break;
                        case 3:
                            ShowShapeWithLargestPerimeter();
                            break;
                        case 4:
                            ShowShapeWithLargestArea();
                            break;
                        case 5:
                            ShowFormulas();
                            break;
                        case 0:
                            isRunning = false;
                            Environment.Exit(0);
                            break;
                    }
                }
            }

            private static void ShowFormulas()
            {
            Console.WriteLine("Select shape:\n"
                + "a, Circle\n"
                + "b, Equilateral Triangle\n"
                + "c, Rectangle\n"
                + "d, RegularPentagon\n"
                + "e, Square\n"
                + "f, Triangle\n");

            ConsoleKeyInfo userInput = Console.ReadKey();

            try
            {
                char shapeLetter = userInput.KeyChar;
                ShowShapeFormula(shapeLetter);
            }
            catch (FormatException)
            {
                Console.WriteLine("That was not OK.");
            }
            }

        private static void ShowShapeFormula(char shapeLetter)
        {
            switch (shapeLetter)
            {
                case 'a':
                    Console.WriteLine("\nCircle area formula: " + Circle.AreaFormula +
                            "\nCircle perimeter formula: " + Circle.PerimeterFormula + "\n");
                    break;
                case 'b':
                    Console.WriteLine("\nEquilateral Triangle area formula: " + EquilateralTriangle.AreaFormula +
                            "\nEquilateral Triangle perimeter formula: " + EquilateralTriangle.PerimeterFormula + "\n");
                    break;
                case 'c':
                    Console.WriteLine("\nRectangle area formula: " + Rectangle.AreaFormula +
                            "\nRectangle perimeter formula: " + Rectangle.PerimeterFormula + "\n");
                    break;
                case 'd':
                    Console.WriteLine("\nRegularPentagon area formula: " + RegularPentagon.AreaFormula +
                            "\nRegularPentagon perimeter formula: " + RegularPentagon.PerimeterFormula + "\n");
                    break;
                case 'e':
                    Console.WriteLine("\nSquare area formula: " + Square.AreaFormula +
                            "\nSquare perimeter formula: " + Square.PerimeterFormula + "\n");
                    break;
                case 'f': 
                    Console.WriteLine("\nTriangle area formula: " + Triangle.AreaFormula +
                            "\nTriangle perimeter formula: " + Triangle.PerimeterFormula + "\n");
                    break;
                default:
                    Console.WriteLine("\nThat was not correct.\n");
                    break;
            }
        }

        private static void ShowShapeWithLargestArea()
            {
            Shape shapeWithLargestArea = shapeCollection.GetLargestShapeByArea();
            Console.WriteLine(shapeWithLargestArea);
            Console.WriteLine(string.Format("Area: {0:.00}\n", shapeWithLargestArea.Area));
        }

            private static void ShowShapeWithLargestPerimeter()
            {
            Shape shapeWithLargestPerimeter = shapeCollection.GetLargestShapeByPerimeter();
            Console.WriteLine(shapeWithLargestPerimeter);
            Console.WriteLine(string.Format("Area: {0:.00}\n", shapeWithLargestPerimeter.Perimeter));
        }

            private static void ShowAllShapes()
            {
                Console.WriteLine(shapeCollection.GetShapesTable());
        }

            private static void AddShape()
            {
            Console.WriteLine("Select the shape to add:\n" +
            "a, Circle\n" +
            "b, Equilateral Triangle\n" +
            "c, Rectangle\n" +
            "d, RegularPentagon\n" +
            "e, Square\n" +
            "f, Triangle\n");

            ConsoleKeyInfo userInput = Console.ReadKey();
            char shapeLetter = 'z';
            try
            {
                shapeLetter = userInput.KeyChar;
                ShowShapeFormula(shapeLetter);
            }
            catch (FormatException)
            {
                Console.WriteLine("That was not OK.");
            }

            switch (shapeLetter)
            {
                case 'a':
                    AddCircle();
                    break;
                case 'b':
                    AddEquilateralTriangle();
                    break;
                case 'c':
                    AddRectangle();
                    break;
                case 'd':
                    AddRegularPentagon();
                    break;
                case 'e':
                    AddSquare();
                    break;
                case 'f':
                    AddTriangle();
                    break;
                default:
                    break;
            }
        }

        private static void AddTriangle()
        {
            double a = GetSide();
            double b = GetSide();
            double c = GetSide();
            shapeCollection.AddShape(new Triangle(a, b, c));
        }

        private static double GetSide()
        {
            double side = 0;
            Console.WriteLine("Please provide side length (double):\n");
            try
            {
                side = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Oops");
            }
            return side;
        }

        private static void AddSquare()
        {
            double side = GetSide();
            shapeCollection.AddShape(new Square(side));
        }

        private static void AddRegularPentagon()
        {
            double side = GetSide();
            shapeCollection.AddShape(new RegularPentagon(side));
        }

        private static void AddRectangle()
        {
            double a = GetSide();
            double b = GetSide();
            shapeCollection.AddShape(new Rectangle(a, b));
        }

        private static void AddEquilateralTriangle()
        {
            double side = GetSide();
            shapeCollection.AddShape(new EquilateralTriangle(side));
        }

        private static void AddCircle()
        {
            double radius = 0;
            Console.WriteLine("Please provide radius:\n");
            try
            {
                radius = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Oops");
            }

            shapeCollection.AddShape(new Circle(radius));
        }
    }

        
    }
