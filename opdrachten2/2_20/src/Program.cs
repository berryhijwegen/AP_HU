using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(1, 1);
            Point point2 = new Point(8, 8);

            Line line = new Line(point1, point2);

            draw_line(line,1);
        }

        public static void draw_line(Line line,double ratio){
            double dx = line.end.posx - line.begin.posx;
            double dy = line.end.posy - line.begin.posy;
        
            for (double i = 1; i < 10*ratio; i++)
            {
                double x = Math.Floor(line.begin.posx + (i/10)*dx);
                double y = Math.Floor(line.begin.posy + (i/10)*dy);
                
                Console.WriteLine(x + " " + y);
            }
        }
    }
}
