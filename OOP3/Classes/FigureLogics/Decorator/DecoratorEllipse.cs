using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    class DecoratorEllipse : FigureEllipse
    {
        protected FigureEllipse _ellipse;

        public new void Draw()
        {
            base.Draw();

            throw new NotImplementedException();
        }
        public DecoratorEllipse(PictureClass pic, FigureEllipse figure) : base(pic)
        {
            _ellipse = figure;
        }
    }
}
