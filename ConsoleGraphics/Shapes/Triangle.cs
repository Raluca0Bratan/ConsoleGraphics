﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGraphics.Shapes
{
    public class Triangle : IShape
    {
        public string Draw()
        {
            return this.GetType().Name;
        }
    }
}
