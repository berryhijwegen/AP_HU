using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Color = System.Drawing.Color;

namespace LinePointGui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Bitmap bitmap = new Bitmap(200, 200);
        public MainWindow()
        {
            InitializeComponent();
            ImageBitmap.Source = BitmapToImageSource(new Bitmap(200,200));
        }

        private void AddLine_Click(object sender, RoutedEventArgs e)
        {
            int x0Val = Int32.Parse(x0.Text);
            int x1Val = Int32.Parse(x1.Text);
            int y0Val = Int32.Parse(y0.Text);
            int y1Val = Int32.Parse(y1.Text);

            Point point1 = new Point(x0Val, y0Val);
            Point point2 = new Point(x1Val, y1Val);
            Line line = new Line(point1, point2);

            line.draw(bitmap, Color.Green);

            ImageBitmap.Source = BitmapToImageSource(bitmap);
        }

        private void Clear_Click(object sender, RoutedEventArgs e) {
            bitmap = new Bitmap(200, 200);
            ImageBitmap.Source = BitmapToImageSource(bitmap);
        }
        public BitmapImage BitmapToImageSource(Bitmap bitmap)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                bitmap.Save(memory, ImageFormat.Bmp);
                memory.Position = 0;
                BitmapImage bitmapimage = new BitmapImage();
                bitmapimage.BeginInit();
                bitmapimage.StreamSource = memory;
                bitmapimage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapimage.EndInit();

                return bitmapimage;
            }
        }
    }
}
