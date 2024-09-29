using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace AbstractFactory
{
    class GreenTriangle : AbstractProductTriangle
    {
        public GreenTriangle() : base(Brushes.Green) { }
    }
}
