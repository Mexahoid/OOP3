using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OOP3
{
    class FigureRectangle : FigureAbstract
    {
        public FigureRectangle(PictureClass pic, ColorScheme ColorScheme) : base(pic, ColorScheme)
        {

        }
        
        public override void Draw()
        {
            _picController.DrawFigure(_Drawer, _corners);
        }

        protected override void _Drawer(int[,] Corners, Graphics g)
        {
            g.FillRectangle(_cc.GetBrush(), Corners[0, 0], Corners[1, 0], Math.Abs(Corners[0, 2] - Corners[0, 0]), Math.Abs(Corners[1, 2] - Corners[1, 0]));
            g.DrawRectangle(_cc.GetPen(), Corners[0, 0], Corners[1, 0], Math.Abs(Corners[0, 2] - Corners[0, 0]), Math.Abs(Corners[1, 2] - Corners[1, 0]));
        }

        public override void Save(ref string Text, XYIJ II, XYIJ JJ)
        {
            Text += "<rect" +
                " x=\"" + _corners[0, 0] + "\"" +
                " y=\"" + _corners[1, 0] + "\"" +
                " width=\"" +  Math.Abs(_corners[0, 0] - _corners[0, 2]) + "\"" +
                " height=\"" + Math.Abs(_corners[1, 0] - _corners[1, 2]) + "\"" +
                _cc["Width"] + 
                _cc["FGColor"] +
                _cc["BGColor"] +
                _cc["Dashes"] +
                "/>\n";
        }
    }
}
