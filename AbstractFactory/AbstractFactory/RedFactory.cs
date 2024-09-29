using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AbstractFactory
{
    internal class RedFactory : AbstractFactrory
    {
        public RedFactory(Grid grid) : base(grid){}

        public override AbstractProductCircle CreateProductCircle()
        {
            AbstractProductCircle circle = new RedCircle();
            AddOnGrid(circle.Ellipse);
            return circle;
        }

        public override AbstractProductTriangle CreateProductTriangle()
        {
            AbstractProductTriangle triangle = new RedTriangle();
            AddOnGrid(triangle.Polygon);
            return triangle;
        }

        public override AbstractProductSquare CreateProductSquare()
        {
            AbstractProductSquare square = new RedSquare();
            AddOnGrid(square.Rectangle);
            return square;
        }
    }
}
