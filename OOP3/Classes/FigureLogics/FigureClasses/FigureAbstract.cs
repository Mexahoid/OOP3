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
        protected double _xCent, _yCent;

        protected PictureClass _picController;
        protected bool _selected;
        protected int _points;

        protected int _selectedPoint;

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
            double xMax = double.MinValue;
            double yMax = double.MinValue;
            double xMin = double.MaxValue;
            double yMin = double.MaxValue;
            for (int i = 0; i < _points; i++)
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

        /// <summary>
        /// Выставляет новые границы области фигуры.
        /// </summary>
        /// <param name="x">Х утягиваемого угла.</param>
        /// <param name="y">Y утягиваемого угла.</param>
        public virtual void ChangeSize(double x, double y)
        {
            /*
            Правый нижний угол
            _corners[0, 2]
            _corners[1, 2]

            Правый верхний угол
            _corners[0, 1]
            _corners[1, 1]

            Левый нижний угол
            _corners[0, 3]
            _corners[1, 3]

            Левый верхний угол
            _corners[0, 2]
            _corners[1, 2]
            */

            //Если увеличиваем размер вправо...
            if (x > _xCent)
            {
                //..и увеличиваем Y (тянем вправо вверх)
                if (y > _yCent)
                {
                    //Изменяем:

                    //Правый верхний на x, y
                    _corners[0, 1] = x;
                    _corners[1, 1] = y;
                    //Левый верхний на y
                    _corners[1, 2] = y;
                    //Правый нижний на х
                    _corners[0, 2] = x;
                }
                //..и уменьшаем Y (тянем вправо вниз)
                else
                {
                    //Изменяем:

                    //Правый нижний на x, y
                    _corners[0, 2] = x;
                    _corners[1, 2] = y;
                    //Левый нижний на y
                    _corners[1, 3] = y;
                    //Правый верхний на х
                    _corners[0, 1] = x;
                }
            }
            //Если увеличиваем размер влево...
            else
            {
                //..и увеличиваем Y (тянем влево вверх)
                if (y > _yCent)
                {
                    //Изменяем:

                    //Левый верхний на x, y
                    _corners[0, 2] = x;
                    _corners[1, 2] = y;
                    //Правый верхний на y
                    _corners[1, 1] = y;
                    //Левый нижний на х
                    _corners[0, 3] = x;
                }
                //..и уменьшаем Y (тянем влево вниз)
                else
                {
                    // Изменяем:

                    //Левый нижний на x, y
                    _corners[0, 3] = x;
                    _corners[1, 3] = y;
                    //Правый нижний на y
                    _corners[1, 2] = y;
                    //Левый верхний на х
                    _corners[0, 2] = x;
                }
            }

            _xCent = (_corners[0, 1] + _corners[0, 2] + _corners[0, 3] + _corners[0, 0]) / 4;
            _yCent = (_corners[1, 1] + _corners[1, 2] + _corners[1, 3] + _corners[1, 0]) / 4;
        }

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

        public void PlaceFigure(double x, double y)
        {
            _corners[0, 0] = _corners[0, 1] = _corners[0, 2] = _corners[0, 3] = x;
            _corners[1, 0] = _corners[1, 1] = _corners[1, 2] = _corners[1, 3] = y;
            for (int i = 0; i < _points; i++)
            {
                _x.Add(x);
                _y.Add(y);
            }

            _xCent = x;
            _yCent = y;
        }

        public virtual void SelectPoint(double x, double y)
        {
            double e = 2.0;
            for (int i = 0; i < _points; i++)
            {
                if (Math.Sqrt((x - _x[i]) * (x - _x[i]) + (y - _y[i]) * (y - _y[i])) <= e)
                {
                    _selectedPoint = i;
                    break;
                }
            }
        }
    }
}
