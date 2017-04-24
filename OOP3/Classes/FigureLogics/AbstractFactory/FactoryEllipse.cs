using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    class FactoryEllipse : IFactory
    {
        private readonly FigureEllipse _protoEll;

        public FactoryEllipse(PictureClass PicController)
        {
            _protoEll = new FigureEllipse(PicController);
        }

        public FigureAbstract CreateFigure()
        {
            return _protoEll.Clone();
        }
    }
}
