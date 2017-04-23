using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    class PrototypeRectangle : Prototype
    {
        private readonly FigureAbstract _figureRectangle;

        public PrototypeRectangle(PictureClass PicController)
        {
            _figureRectangle = new FigureRectangle(PicController);
        }


    }
}
