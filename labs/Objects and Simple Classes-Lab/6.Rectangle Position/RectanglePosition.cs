using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _6.Rectangle_Position
{
    public class RectanglePosition
    {
        class Rectangle
        {
            public int Top { get; set; }
            public int Left { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }

            public int Bottom
            {
                get { return Top + Height; }
            }

            public int Right
            {
                get { return Left + Width; }
            }

            public bool IsInsight(Rectangle r)
            {
                bool isInsight = (r.Left <= Left) && (r.Right >= Right) && (r.Top <= Top) && (r.Bottom >= Bottom);
                return isInsight;
            }
        }
         static Rectangle ReadRectangle()
        {
            int[] rectanlge = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Rectangle r = new Rectangle()
            {
                Left = rectanlge[0],
                Top = rectanlge[1],
                Width = rectanlge[2],
                Height = rectanlge[3]
            };
            return r;
        }
        public static void Main()
        {
            Rectangle r1=ReadRectangle();
            Rectangle r2 = ReadRectangle();
            if (r1.IsInsight(r2))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }
    }
}
