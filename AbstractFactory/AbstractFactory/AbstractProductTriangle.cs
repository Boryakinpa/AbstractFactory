using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Ink;
using System.Windows.Media;
using System.Windows.Shapes;

namespace AbstractFactory
{
    abstract class AbstractProductTriangle
    {
        public Polygon Polygon { get; private set; } = new Polygon();
        private protected AbstractProductTriangle(SolidColorBrush color) 
        {
            Polygon.Points = new PointCollection(new Point[]
            {
                new Point(150, 30),
                new Point(100, 200),
                new Point(200, 200)
            });
            Polygon.Fill = color;
            Polygon.Stroke = color;
            Polygon.StrokeThickness = 2;
        }
    }
}
