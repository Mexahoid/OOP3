using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OOP3
{
    class FigureLine : FigureAbstract
    {
        public FigureLine(PictureClass pic) : base(pic)
        {

        }

        public override void Draw()
        {
            _picController.DrawFigure(_Drawer, _corners);
        }

        protected override void _Drawer(int[,] Corners, Graphics g)
        {
            g.DrawLine(Pens.Black, Corners[0, 0], Corners[1, 0], Corners[0, 2], Corners[1, 2]);
        }
    }
}
