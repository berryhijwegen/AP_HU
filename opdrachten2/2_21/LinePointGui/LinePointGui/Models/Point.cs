using System;
using System.Drawing;
using System.Drawing.Imaging;
namespace LinePointGui
{
    class Point : Drawable
    {
        public int posx;
        public int posy;

        public Point(int x, int y){
            posx = x;
            posy = y;
        }

        public Bitmap draw(Bitmap bitmap, Color color){
            bitmap.SetPixel(posx, posy, color);
            return bitmap;
        }
    }
}
