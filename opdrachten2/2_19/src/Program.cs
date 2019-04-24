using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(4, 4);
            Point point2 = new Point(6, 4);

            Line line = new Line(point1, point2);

            point1.draw();
            Console.WriteLine();
            point2.draw();
            Console.WriteLine();
            line.draw();
        }
    }
}
