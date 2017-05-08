using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OOP3
{
    class FigureEllipse : FigureAbstract
    {
        public FigureEllipse(PictureClass pic, ColorScheme ColorScheme) : base(pic, ColorScheme)
        {

        }

        public override void Draw()
        {
            _picController.DrawFigure(_Drawer, _corners);
        }

        protected override void _Drawer(int[,] Corners, Graphics g)
        {
            if (_selected)
                g.DrawRectangle(Pens.LightGray, Corners[0, 0], Corners[1, 0] - 0, 
                    Math.Abs(Corners[0, 2] - Corners[0, 0]), Math.Abs(Corners[1, 2] - Corners[1, 0]));
            g.FillEllipse(_cc.GetBrush(), Corners[0, 0], Corners[1, 0],
                Math.Abs(Corners[0, 2] - Corners[0, 0]), Math.Abs(Corners[1, 2] - Corners[1, 0]));
            g.DrawEllipse(_cc.GetPen(), Corners[0, 0], Corners[1, 0] - 0,
                Math.Abs(Corners[0, 2] - Corners[0, 0]), Math.Abs(Corners[1, 2] - Corners[1, 0]));
        }
    }
}
