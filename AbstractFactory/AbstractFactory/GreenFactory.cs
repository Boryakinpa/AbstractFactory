using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AbstractFactory
{
    class GreenFactory : AbstractFactrory
    {
        public GreenFactory(Grid grid) : base(grid) { }

        public override AbstractProductCircle CreateProductCircle()
        {
            AbstractProductCircle circle = new GreenCircle();
            AddOnGrid(circle.Ellipse);
            return circle;
        }

        public override AbstractProductTriangle CreateProductTriangle()
        {
            AbstractProductTriangle triangle = new GreenTriangle();
            AddOnGrid(triangle.Polygon);
            return triangle;
        }

        public override AbstractProductSquare CreateProductSquare()
        {
            AbstractProductSquare square = new GreenSquare();
            AddOnGrid(square.Rectangle);
            return square;
        }
    }
}
