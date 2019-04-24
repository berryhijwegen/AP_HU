using System;

namespace Interfaces
{
    class Point : Drawable
    {
        private int posx;
        private int posy;

        public Point(int x, int y){
            posx = x;
            posy = y;
        }


        public void draw(){
            Console.WriteLine(String.Format("{0},{1}", posx, posy));
        }
    }
}
