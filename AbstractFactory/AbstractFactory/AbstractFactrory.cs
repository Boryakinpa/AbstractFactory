using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace AbstractFactory
{
    abstract class AbstractFactrory
    {

        private Grid _grid;
        public AbstractFactrory(Grid grid)
        {
            _grid = grid;
        }

        public void AddOnGrid(UIElement element)
        {
            _grid.Children.Add(element);
        }

        public abstract AbstractProductCircle CreateProductCircle();
        public abstract AbstractProductTriangle CreateProductTriangle();
        public abstract AbstractProductSquare CreateProductSquare();
    }
}
