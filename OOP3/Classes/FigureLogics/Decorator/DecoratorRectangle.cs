using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    class DecoratorRectangle : FigureDecorator
    {
        public DecoratorRectangle(PictureClass pic) : base(pic)
        { }

        public override void Draw()
        {
            _figure.Draw();
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
