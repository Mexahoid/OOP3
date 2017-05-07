using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    class FactoryComplex : IFactory
    {
        private readonly FigureComplex _protoComplex;

        public FactoryComplex(PictureClass PicController)
        {
            _protoComplex = new FigureComplex(PicController);
        }

        public FigureAbstract CreateFigure()
        {
            return _protoComplex.Clone();
        }
    }
}
