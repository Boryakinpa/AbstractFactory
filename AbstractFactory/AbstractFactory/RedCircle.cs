using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Ink;
using System.Windows.Media;
using System.Windows.Shapes;

namespace AbstractFactory
{
    internal class RedCircle : AbstractProductCircle
    {
        public RedCircle() : base(Brushes.Red){}
    }
}
