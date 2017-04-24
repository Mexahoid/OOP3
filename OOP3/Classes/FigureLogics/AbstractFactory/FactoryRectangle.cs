using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    class FactoryRectangle : IFactory
    {
        private readonly FigureRectangle _protoRect;

        public FactoryRectangle(PictureClass PicController)
        {
            _protoRect = new FigureRectangle(PicController);
        }

        public FigureAbstract CreateFigure()
        {
            return _protoRect.Clone();
        }
    }
}
