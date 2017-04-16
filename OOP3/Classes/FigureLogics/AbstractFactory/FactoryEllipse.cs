using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    class FactoryEllipse : IFactoryAbstract
    {
        private Prototype _figurePrototype;

        public FactoryEllipse()
        {
            _figurePrototype = new PrototypeEllipse();
        }
        public IFigure CreateFigure()
        {
            throw new NotImplementedException();
        }
    }
}
