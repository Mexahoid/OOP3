using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    class FactoryLine : IFactory
    {
        private readonly FigureLine _protoLine;

        public FactoryLine(PictureClass PicController, ColorScheme CS)
        {
            _protoLine = new FigureLine(PicController, CS);
        }

        public FigureAbstract CreateFigure(ColorScheme ColorScheme)
        {
            FigureAbstract Out = _protoLine.Clone();
            Out.CC = ColorScheme;
            return Out;
        }
    }
}
