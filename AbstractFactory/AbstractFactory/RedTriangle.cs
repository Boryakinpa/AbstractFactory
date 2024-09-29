﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace AbstractFactory
{
    internal class RedTriangle : AbstractProductTriangle
    {
        public RedTriangle() : base(Brushes.Red) {}
    }
}
