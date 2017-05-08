using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    class FactoryComplex : IFactory
    {
        private readonly FigureComplex _protoComplex;

        public FactoryComplex(PictureClass PicController, ColorScheme CS)
        {
            _protoComplex = new FigureComplex(PicController, CS);
        }

        public FigureAbstract CreateFigure(ColorScheme ColorScheme)
        {
            return _protoComplex.Clone();
        }
    }
}
