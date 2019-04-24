using System;

namespace Interfaces
{
    class Line : Drawable
    {
        public Point begin;
        public Point end;

        public Line(Point x, Point y){
            begin = x;
            end = y;
        }

        public void draw(){
            begin.draw();
            end.draw();
        }
    }
}
