﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packt.CS6
{
    public struct DisplacementVector
    {
        public int X;
        public int Y;
        public DisplacementVector(int initialX, int initialY) // initialising -> contructor
        {
            X = initialX;
            Y = initialY;
        }

        // this specifies what is done when + operator is used
        public static DisplacementVector operator +(DisplacementVector vector1, DisplacementVector vector2)
        {
            return new DisplacementVector(vector1.X + vector2.X, vector1.Y + vector2.Y);
        }
    }
}
