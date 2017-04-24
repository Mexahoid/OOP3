using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    class FactoryLine : IFactory
    {
        private readonly FigureLine _protoLine;

        public FactoryLine(PictureClass PicController)
        {
            _protoLine = new FigureLine(PicController);
        }

        public FigureAbstract CreateFigure()
        {
            return _protoLine.Clone();
        }
    }
}
