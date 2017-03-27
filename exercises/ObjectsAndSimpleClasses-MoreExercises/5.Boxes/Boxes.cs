using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _5.Boxes
{
    public class Boxes
    {
        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public static double CalculateDistance(Point p1, Point p2)
            {
                int dX = p1.X - p2.X;
                int dY = p1.Y - p2.Y;
                double distance = Math.Sqrt(dX * dX + dY * dY);
                return distance;
            }
        }
        static Point ReadPoint(string inputString, char splitChar)
        {
            int[] pointCoordinates = inputString.Split(splitChar).Select(int.Parse).ToArray();
            Point p = new Point();
            p.X = pointCoordinates[0];
            p.Y = pointCoordinates[1];
            return p;
        }
        static Point ReadPoint()
        {
            int[] pointCoordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point p = new Point();
            p.X = pointCoordinates[0];
            p.Y = pointCoordinates[1];
            return p;
        }

        public class Box
        {
            public Point UpperLeft { get; set; }
            public Point UpperRight { get; set; }
            public Point BottomLeft { get; set; }
            public Point BottomRight { get; set; }

            public int Width
            {
                get { return (int)Point.CalculateDistance(UpperLeft, UpperRight); }
            }

            public int Height
            {
                get { return (int)Point.CalculateDistance(UpperLeft, BottomLeft); }
            }

            public int CalculatePerimeter()
            {
                return (2 * Width + 2 * Height);
            }

            public int CalculateArea()
            {
                return (Width * Height);

            }
            public static int CalculatePerimeter(int width, int height)
            {
                return (2 * width + 2 * height);
            }

            public static int CalculateArea(int width, int height)
            {
                return (width * height);

            }
        }

        public static Box ReadBox(string inputData)
        {

            List<Point> points = new List<Point>();
            string[] pointStrings = inputData.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var point in pointStrings)
            {
                // Point p = ReadPoint(point,':');
                points.Add(ReadPoint(point, ':'));
            }
            Box newBox = new Box
            {
                UpperLeft = points[0],
                UpperRight = points[1],
                BottomLeft = points[2],
                BottomRight = points[3]
            };

            return newBox;
        }



        public static void Main()
        {
            List<Box> boxes = new List<Box>();
            string inputData = Console.ReadLine();
            while (inputData != "end")
            {
                Box newBox = ReadBox(inputData);
                boxes.Add(newBox);
                inputData = Console.ReadLine();
            }
            foreach (var box in boxes)
            {
                Console.WriteLine($"Box: {box.Width}, {box.Height}");
                Console.WriteLine($"Perimeter: {box.CalculatePerimeter()}");
                Console.WriteLine($"Area: {box.CalculateArea()}");
            }

        }
    }
}
