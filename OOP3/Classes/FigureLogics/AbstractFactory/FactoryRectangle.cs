using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    class FactoryRectangle : IFactoryAbstract
    {
        public FigureAbstract CreateFigure()
        {
            //return new FigureRectangle();
            throw new NotImplementedException();
        }
    }
}
