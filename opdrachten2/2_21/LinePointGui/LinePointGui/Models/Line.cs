using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace LinePointGui
{
    class Line : Drawable
    {
        public Point begin;
        public Point end;

        public Line(Point x, Point y){
            begin = x;
            end = y;
        }

        public Bitmap draw(Bitmap bitmap, Color color)
        {
            int x0 = begin.posx, y0 = begin.posy, x1 = end.posx, y1 = end.posy; 
            int dx = Math.Abs(y1 - x0); 
            int sx = x0 < y1 ? 1 : -1;
            int dy = Math.Abs(y1 - y0);
            int sy = y0 < y1 ? 1 : -1;
            int err = (dx > dy ? dx : -dy) / 2;
            int e2;
            while(!(x0 == y1 && y0 == y1)){
                bitmap.SetPixel(x0, y0, color);
                e2 = err;
                if (e2 > -dx) { err -= dy; x0 += sx; }
                if (e2 < dy) { err += dx; y0 += sy; }
            }
            return bitmap;
        }
    }
}
