using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows;
using System.CodeDom.Compiler;

namespace AbstractFactory
{
    abstract class AbstractProductCircle
    {
        public Ellipse Ellipse { get; private set; } = new Ellipse();
        private protected AbstractProductCircle(SolidColorBrush color)
        {
            Ellipse.Width = 50;
            Ellipse.Height = 50;
            Ellipse.VerticalAlignment = VerticalAlignment.Top;
            Ellipse.Fill = color;
            Ellipse.Stroke = color;
            Ellipse.StrokeThickness = 3;
        }
    }
}
