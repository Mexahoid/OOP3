using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    class FigureEllipse : FigureAbstract
    {
        public FigureEllipse(PictureClass pic) : base(pic)
        {
            _points = 30;
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }

        public override void MoveObj(double dx, double dy)
        {
            throw new NotImplementedException();
        }

        public override void SelectionDraw(double x, double y)
        {
            throw new NotImplementedException();
        }
    }
}
