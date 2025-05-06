﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Point2D
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Point2D(int x, int y)
        {
            Validator.AssertValueInRange(x, 0, 1000, nameof(X)); // Пример: карта 1000x1000
            Validator.AssertValueInRange(y, 0, 1000, nameof(Y));

            X = x;
            Y = y;
        }
    }
}
