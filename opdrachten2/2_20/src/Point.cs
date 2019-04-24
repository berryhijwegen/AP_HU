using System;

namespace Interfaces
{
    class Point : Drawable
    {
        public int posx;
        public int posy;

        public Point(int x, int y){
            posx = x;
            posy = y;
        }


        public void draw(){
            Console.WriteLine(String.Format("{0},{1}", posx, posy));
        }
    }
}
