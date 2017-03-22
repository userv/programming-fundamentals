using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Closest_Two_Points
{
    public class ClosestTwoPoints
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

        static Point[] FindClosestPoints(Point[] points)
        {
            double minDistance = double.MaxValue;
            Point[] closestPoints=new Point[2];
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i+1; j < points.Length; j++)
                {
                    double distance = CalculateDistance(points[i], points[j]);
                       
                    if (distance<minDistance)
                    {
                        minDistance = distance;
                        closestPoints[0] = points[i];
                        closestPoints[1] = points[j];
                    }
                }
            }
            return closestPoints;
        }
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Point[] points=new Point[n];
             for (int i = 0; i < n; i++)
            {
                points[i]=ReadPoint();
            }
            Point[] closestPoints = FindClosestPoints(points);
            double distance = CalculateDistance(closestPoints[0], closestPoints[1]);
            Console.WriteLine($"{distance:F3}");
            Console.WriteLine($"({closestPoints[0].X}, {closestPoints[0].Y})");
            Console.WriteLine($"({closestPoints[1].X}, {closestPoints[1].Y})");
        }
    }
}
