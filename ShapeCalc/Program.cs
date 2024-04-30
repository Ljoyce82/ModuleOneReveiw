using System.Xml.Serialization;

namespace ShapeCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exitRequested = false; //checks for user exit on case 5

            while (!exitRequested) //keep program running till user wants to exit
            { 
            Console.WriteLine("Select a shape");
            Console.WriteLine("1. Circle\n2. Triangle\n3. Rectangle\n4. Square\n5: Exit ");
            Console.WriteLine();
            Console.WriteLine("Enter Your choice:");
            
            int choice = int.Parse(Console.ReadLine());

                switch (choice) //let user choose shapes and values
                {
                    case 1:
                        Console.WriteLine("Enter the radius of the Circle: ");
                        double circleRadius = double.Parse(Console.ReadLine()); ;
                        Console.WriteLine("Area of the Cicle: " + Circle(circleRadius));
                        break;

                    case 2:
                        Console.WriteLine("Enter the base length of the Triangle: ");
                        double triangleBase = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the height of the Triangle: ");
                        double triangleHeight = double.Parse(Console.ReadLine());
                        Console.WriteLine("Area of the Triangle: " + Triangle(triangleBase, triangleHeight));
                        break;

                    case 3:
                        Console.WriteLine("Enter the length of the Rectangle: ");
                        double rentangleLength = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the width of the Rectangle: ");
                        double rectangleWidth = double.Parse(Console.ReadLine());
                        Console.WriteLine("Area of the Rectangle: " + Rectangle(rectangleWidth, rentangleLength));
                        break;

                    case 4:
                        Console.WriteLine("Enter the side length of the square: ");
                        double squareside = double.Parse(Console.ReadLine());
                        Console.WriteLine("Area of the Square: " + Square(squareside));
                        break;

                    case 5:
                        exitRequested = true;
                        break;

                    default:
                        Console.WriteLine("Please choose a shape");
                        break;
                }
            }
        }
        // methods for calling calculations
        public static double Circle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static double Triangle(double baseLength, double height)
        {
            return 0.5 * (baseLength + height);
        }

        public static double Rectangle(double length, double width)
        {
            return length * width;
        }

        public static double Square(double side)
        {
            return Math.Pow(side, 2);
        }
    }
}
