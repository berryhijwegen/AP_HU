using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace LinePointGui
{
    interface Drawable
    {
        Bitmap draw(Bitmap bitmap, Color color);
    }
}
