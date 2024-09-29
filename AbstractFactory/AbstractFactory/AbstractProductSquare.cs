using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Ink;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace AbstractFactory
{
    abstract class AbstractProductSquare
    {
        public Rectangle Rectangle { get; private set; } = new Rectangle();
        private protected AbstractProductSquare(SolidColorBrush color) 
        {
            Rectangle.Width = 100;
            Rectangle.Height = 100;
            Rectangle.Fill = color;
            Rectangle.Stroke = color;
            Rectangle.StrokeThickness = 2;
        }
    }
}
