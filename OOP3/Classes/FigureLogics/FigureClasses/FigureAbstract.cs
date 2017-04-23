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



        public bool Selected { get { return _selected; } set { _selected = value; } }

        protected FigureAbstract(PictureClass PictureController)
        {
            _corners = new double[2, 4];
            _selected = false;
            _picController = PictureController;
            _x = new List<double>();
            _y = new List<double>();
        }

        public bool CursorIn(double X, double Y)
        {
            double Eps = 2.0;
            return (_corners[0, 0] - Eps <= X) && (X <= _corners[0, 2] + Eps) &&
                    (_corners[1, 0] - Eps <= Y) && (Y <= _corners[1, 2] + Eps);
        }

        public Tuple<List<double>, List<double>> GetPoints()
        {
            return Tuple.Create(_x, _y);
        }

        protected void ResetPoints()
        {
            int C = _x.Count;

            double xMax = double.MinValue;
            double yMax = double.MinValue;
            double xMin = double.MaxValue;
            double yMin = double.MaxValue;
            for (int i = 0; i < C; i++)
            {
                if (_x[i] > xMax)
                {
                    xMax = _x[i];
                }
                if (_x[i] < xMin)
                {
                    xMin = _x[i];
                }
                if (_y[i] > yMax)
                {
                    yMax = _y[i];
                }
                if (_y[i] < yMin)
                {
                    yMin = _y[i];
                }
            }

            _corners[0, 0] = xMin;
            _corners[1, 0] = yMax;

            _corners[0, 1] = xMax;
            _corners[1, 1] = yMax;

            _corners[0, 2] = xMax;
            _corners[1, 2] = yMin;

            _corners[0, 3] = xMin;
            _corners[1, 3] = yMin;

        }

        public abstract void SelectionDraw(double x, double y);

        public abstract void MoveObj(double dx, double dy);

        public abstract void Draw();

        /// <summary>
        /// Метод для проверки нахождения фигуры в регионе.
        /// </summary>
        /// <param name="luX">Х верхнего левого угла.</param>
        /// <param name="luY">Y верхнего левого угла.</param>
        /// <param name="rdX">X нижнего правого угла.</param>
        /// <param name="rdY">Y нижнего правого угла</param>
        public virtual void IsInSelectionArea(double luX, double luY, double rdX, double rdY)
        {
            _selected = _corners[1, 0] < rdY || _corners[1, 2] > luY || _corners[0, 2] < luX || _corners[0, 0] > rdX;
        }

        public FigureAbstract Clone()
        {
            return (FigureAbstract)MemberwiseClone();
        }
    }
}
