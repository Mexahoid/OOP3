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
            _points = 2;
        }

        public override void Draw()
        {
            //_picController.DrawFigure();
        }

        private void Drawer(List<int> X, List<int> Y, Graphics g)
        {
            g.DrawLine(Pens.Black, X[0], Y[0], X[1], Y[1]);
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
