using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Distance_between_Points
{
    public class DistanceBetweenPoints
    {
        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }

        }
        static Point ReadPoint()
        {
            int[] pointCoordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point p = new Point();
            p.X = pointCoordinates[0];
            p.Y = pointCoordinates[1];
            return p;
        }

        static double CalculateDistance(Point p1, Point p2)
        {
            int dX = p1.X - p2.X;
            int dY = p1.Y - p2.Y;
            double distance = Math.Sqrt(dX * dX + dY * dY);
            return distance;
        }
        public static void Main()
        {

            Point p1 = ReadPoint();
            Point p2 = ReadPoint();
            Console.WriteLine("{0:F3}", CalculateDistance(p1, p2));

        }



    }
}
