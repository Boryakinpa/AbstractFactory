using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace AbstractFactory
{
    class BlueSquare : AbstractProductSquare
    {
        public BlueSquare() : base(Brushes.Blue) { }
    }
}
