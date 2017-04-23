using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    class FigureEllipse : FigureAbstract, IFigure
    {
        public FigureEllipse(PictureClass pic) : base(pic)
        {
            _points = 30;
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }

        public void MoveObj(double dx, double dy)
        {
            throw new NotImplementedException();
        }

        public void SelectionDraw(double x, double y)
        {
            throw new NotImplementedException();
        }
    }
}
