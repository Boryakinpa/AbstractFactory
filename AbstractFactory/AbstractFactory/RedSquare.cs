using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace AbstractFactory
{
    internal class RedSquare : AbstractProductSquare
    {
        public RedSquare() : base(Brushes.Red) { }
    }
}
