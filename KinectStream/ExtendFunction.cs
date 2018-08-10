using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Media.Imaging;
using Microsoft.Kinect;
using System.Windows;

namespace KinectStream
{
    public static class ExtendFunction
    {
        public static Joint ScaleTo(this Joint joint, double width, double height)
        {
            return ScaleTo(joint, width, height);
        }

        public static void DrawPoint(this Canvas canvas, ColorSpacePoint colorSpacePoint)
        {
            //2D coordinate
            Point point2D = new Point();

            point2D.X = colorSpacePoint.X;
            point2D.Y = colorSpacePoint.Y;

            Ellipse ellipse = new Ellipse
            {
                Width = 20, Height = 20, Fill = new SolidColorBrush(Colors.Red)
            };

            Canvas.SetLeft(ellipse, point2D.X - ellipse.Width / 2);
            Canvas.SetTop(ellipse, point2D.Y - ellipse.Height / 2);

            canvas.Children.Add(ellipse);
        }
    }
}
