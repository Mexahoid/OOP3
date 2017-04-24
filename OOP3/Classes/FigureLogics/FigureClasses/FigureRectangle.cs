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

        }
        
        public override void Draw()
        {
            throw new NotImplementedException();
        }
        
        public override void MoveObj(double dx, double dy)
        {
            throw new NotImplementedException();
        }
    }
}
