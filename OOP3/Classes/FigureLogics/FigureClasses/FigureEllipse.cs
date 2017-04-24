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

        public override void ChangeSize(double x, double y)
        {
            if(x > _xCent)
            {
                if (y > _yCent)
                {

                }
                else
                {

                }
            }
            else
            {
                if (y > _yCent)
                {

                }
                else
                {

                }
            }

            /*for (int i = 0; i <= Lp - 1; i++)
            {
                obj[L - 1].points[i].x = x_0 + Ea * Math.Cos(2 * i * Math.PI / Lp);
                obj[L - 1].points[i].y = y_0 + Eb * Math.Sin(2 * i * Math.PI / Lp);
            }*/
            ResetPoints();
        }
    }
}
