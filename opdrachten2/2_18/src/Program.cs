using System;

namespace PuntenEnLijnen
{
    class Program
    {
        static void Main(string[] args)
        {
            draw_line(0,0,8,8,0.5);
        }

        public static void draw_line(int x0, int y0, int x1, int y1,double ratio){
            double dx = x1 - x0;
            double dy = y1 - y0;
        
            for (double i = 1; i < 10*ratio; i++)
            {
                double x = Math.Floor(x0 + (i/10)*dx);
                double y = Math.Floor(y0 + (i/10)*dy);
                
                Console.WriteLine(x + " " + y);
            }
        }
    }
}
