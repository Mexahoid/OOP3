﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    class PrototypeRectangle : Prototype
    {
        private readonly IFigure _figureRectangle;

        public PrototypeRectangle()
        {
            _figureRectangle = new FigureRectangle();
        }
    }
}