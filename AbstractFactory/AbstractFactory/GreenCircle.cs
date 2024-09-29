﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace AbstractFactory
{
    class GreenCircle : AbstractProductCircle
    {
        public GreenCircle() : base(Brushes.Green) { }
    }
}