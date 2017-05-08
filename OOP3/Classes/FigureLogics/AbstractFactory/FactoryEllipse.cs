using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    class FactoryEllipse : IFactory
    {
        private readonly FigureEllipse _protoEll;

        public FactoryEllipse(PictureClass PicController, ColorScheme CS)
        {
            _protoEll = new FigureEllipse(PicController, CS);
        }

        public FigureAbstract CreateFigure(ColorScheme ColorScheme)
        {
            FigureAbstract Out = _protoEll.Clone();
            Out.CC = ColorScheme;
            return Out;
        }
    }
}
