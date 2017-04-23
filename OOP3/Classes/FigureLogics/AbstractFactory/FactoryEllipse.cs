using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    class FactoryEllipse : IFactoryAbstract
    {
        private Prototype _figurePrototype;
        private PictureClass _picController;

        public FactoryEllipse()
        {
            _figurePrototype = new PrototypeEllipse();
        }
        public FigureAbstract CreateFigure()
        {
            return new FigureEllipse(_picController);
        }
    }
}
