﻿using System;

namespace Geometria
{
    public class Punto
    {
        private int x;
        private int y;

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get { return this.x; }
        }

        public int Y
        {
            get { return this.y; }
        }
    }
}
