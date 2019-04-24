using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Interfaces {
    static class Program
    {
        static void Main()
        {
            Point point1 = new Point(0,0);
            Point point2 = new Point(50,50);
            Line line1 = new Line(point1, point2);
            
            Point point3 = new Point(51,51);
            Point point4 = new Point(100,100);
            Line line2 = new Line(point3, point4);
            
            Point point5 = new Point(101,101);
            Point point6 = new Point(150,150);
            Line line3 = new Line(point5, point6);

            Point point7 = new Point(151,151);
            Point point8 = new Point(200,200);
            Line line4 = new Line(point7, point8);

            Point point9 = new Point(120, 50);

            Bitmap bitmap = new Bitmap(200, 200);

            line1.draw(bitmap, Color.Green);
            line2.draw(bitmap, Color.Red);
            line3.draw(bitmap, Color.Blue);
            line4.draw(bitmap, Color.Chocolate);
            point9.draw(bitmap, Color.MediumVioletRed);
            
            bitmap.Save("line.png", ImageFormat.Png);
        }
    }
}