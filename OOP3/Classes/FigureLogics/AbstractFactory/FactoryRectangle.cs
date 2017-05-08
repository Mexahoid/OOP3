using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    class FactoryRectangle : IFactory
    {
        private readonly FigureRectangle _protoRect;

        public FactoryRectangle(PictureClass PicController, ColorScheme CS)
        {
            _protoRect = new FigureRectangle(PicController, CS);
        }

        public FigureAbstract CreateFigure(ColorScheme ColorScheme)
        {
            FigureAbstract Out = _protoRect.Clone();
            Out.CC = ColorScheme;
            return Out;
        }
    }
}
