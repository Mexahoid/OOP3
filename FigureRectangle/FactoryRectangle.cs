using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaces;

namespace FigureRectangleLib
{
    class FactoryRectangle : IFactoryAbstract
    {
        public IFigure CreateFigure()
        {
            return new FigureRectangle();
        }
    }
}
