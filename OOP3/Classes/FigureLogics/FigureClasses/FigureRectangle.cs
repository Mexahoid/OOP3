using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    class FigureRectangle : FigureAbstract
    {
        public FigureRectangle(PictureClass pic) : base(pic)
        {
            _points = 4;
        }
        
        public override void Draw()
        {
            throw new NotImplementedException();
        }
        
        public override void MoveObj(double dx, double dy)
        {
            throw new NotImplementedException();
        }
        
        public override void ChangeSize(double x, double y)
        {
            base.ChangeSize(x, y);
            _x[1] = x;
            _x[2] = x;

            _y[2] = y;
            _y[3] = y;
        }
    }
}
