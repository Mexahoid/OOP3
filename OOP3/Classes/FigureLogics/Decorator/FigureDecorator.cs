using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    abstract class FigureDecorator : FigureAbstract
    {
        protected FigureAbstract _figure;

        public FigureDecorator(PictureClass pic) : base(pic)
        { }
    }
}
