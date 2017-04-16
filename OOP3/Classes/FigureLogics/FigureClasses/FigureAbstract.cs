using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    abstract class FigureAbstract : IFigure
    {
        protected List<double> _x, _y;
        protected double[,] _corners;

        protected PictureClass _picController;
        protected bool _selected;
        protected int _points;

        public bool Selected { get => _selected; set => _selected = value; }

        protected FigureAbstract(PictureClass PictureController)
        {
            _corners = new double[2, 4];
            _selected = false;
            _picController = PictureController;
            _x = new List<double>();
            _y = new List<double>();
        }

        public abstract void Draw();

        public abstract void MoveObj(double dx, double dy);

        public abstract void SelectionDraw(double x, double y);

        public bool CursorIn(double X, double Y)
        {
            double Eps = 2.0;
            return (_corners[0, 0] - Eps <= X) && (X <= _corners[0, 2] + Eps) &&
                    (_corners[1, 0] - Eps <= Y) && (Y <= _corners[1, 2] + Eps);
        }
    }
}
