﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Shapes
{
    class Segment : Polygon
    {
        public Segment(Point point, Point point2)
        {
            AddPoint(point);
            AddPoint(point2);
        }
    }
}