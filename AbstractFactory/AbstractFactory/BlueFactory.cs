using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AbstractFactory
{
    class BlueFactory : AbstractFactrory
    {
        public BlueFactory(Grid grid) : base(grid) { }

        public override AbstractProductCircle CreateProductCircle()
        {
            AbstractProductCircle circle = new BlueCircle();
            AddOnGrid(circle.Ellipse);
            return circle;
        }

        public override AbstractProductTriangle CreateProductTriangle()
        {
            AbstractProductTriangle triangle = new BlueTriangle();
            AddOnGrid(triangle.Polygon);
            return triangle;
        }

        public override AbstractProductSquare CreateProductSquare()
        {
            AbstractProductSquare square = new BlueSquare();
            AddOnGrid(square.Rectangle);
            return square;
        }
    }
}
