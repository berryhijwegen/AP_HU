using System;

namespace Interfaces
{
    class Line : Drawable
    {
        private Point begin;
        private Point end;

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
