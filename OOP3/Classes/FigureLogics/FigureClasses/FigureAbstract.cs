using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace OOP3
{
    abstract class FigureAbstract : IFigure, ICloneable
    {
        #region Инфо

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
        _corners[0, 0]
        _corners[1, 0]
        */

        #endregion

        protected double[,] _corners;
        protected PictureClass _picController;
        protected bool _selected;
        protected int _selectedPoint;
        protected ColorScheme _cc;
        
        public virtual bool Selected { get { return _selected; } set { _selected = value; } }

        public ColorScheme CC { set { _cc = value; } }

        protected FigureAbstract(PictureClass PictureController, ColorScheme ColorScheme)
        {
            _corners = new double[2, 4];
            _selected = false;
            _picController = PictureController;
            _cc = ColorScheme;
        }

        public bool CursorIn(double X, double Y)
        {
            double Eps = 2.0;
            return (_corners[0, 0] - Eps <= X) && (X <= _corners[0, 2] + Eps) &&
                    (_corners[1, 2] - Eps <= Y) && (Y <= _corners[1, 0] + Eps);
        }

        public double[,] GetPoints()
        {
            return _corners;
        }

        /// <summary>
        /// Выставляет новые границы области фигуры.
        /// </summary>
        /// <param name="x">Х утягиваемого угла.</param>
        /// <param name="y">Y утягиваемого угла.</param>
        public virtual void ChangeSize(double x, double y)
        {
            double eps = 5.0;
            switch (_selectedPoint)
            {
                //Взяли верхний левый угол
                //Не изменяется нижний правый
                case 0:
                    if (y <= _corners[1, 2] + eps && x >= _corners[0, 2] + eps)
                        _selectedPoint = 2;
                    else
                    {
                        if (y <= _corners[1, 2])
                        {
                            _selectedPoint = 3;
                        }
                        if (x >= _corners[0, 2])
                        {
                            _selectedPoint = 1;
                        }
                    }
                    //Изменяем:

                    //Левый верхний на x, y
                    _corners[0, 0] = x;
                    _corners[1, 0] = y;
                    //Правый верхний на y
                    _corners[1, 1] = y;
                    //Левый нижний на х
                    _corners[0, 3] = x;
                    break;
                //Взяли верхний правый угол
                //Не изменяется нижний левый
                case 1:
                    if (y <= _corners[1, 3] && x <= _corners[0, 3])
                        _selectedPoint = 3;
                    else
                    {
                        if (y <= _corners[1, 3])
                        {
                            _selectedPoint = 2;
                        }
                        if (x <= _corners[0, 3])
                        {
                            _selectedPoint = 0;
                        }
                    }
                    //Изменяем:

                    //Правый верхний на x, y
                    _corners[0, 1] = x;
                    _corners[1, 1] = y;
                    //Левый верхний на y
                    _corners[1, 0] = y;
                    //Правый нижний на х
                    _corners[0, 2] = x;
                    break;
                //Взяли нижний правый угол
                //Не изменяется верхний левый
                case 2:
                    if (y >= _corners[1, 0] && x <= _corners[0, 0])
                        _selectedPoint = 0;
                    else
                    {
                        if (y >= _corners[1, 0])
                        {
                            _selectedPoint = 1;
                        }
                        if (x <= _corners[0, 0])
                        {
                            _selectedPoint = 3;
                        }
                    }
                    //Изменяем:

                    //Правый нижний на x, y
                    _corners[0, 2] = x;
                    _corners[1, 2] = y;
                    //Левый нижний на y
                    _corners[1, 3] = y;
                    //Правый верхний на х
                    _corners[0, 1] = x;
                    break;
                //Взяли нижний левый угол
                //Не изменяется верхний правый
                case 3:
                    if (y >= _corners[1, 1] && x >= _corners[0, 1])
                        _selectedPoint = 1;
                    else
                    {
                        if (y >= _corners[1, 1])
                        {
                            _selectedPoint = 0;
                        }
                        if (x >= _corners[0, 1])
                        {
                            _selectedPoint = 2;
                        }
                    }
                    // Изменяем:

                    //Левый нижний на x, y
                    _corners[0, 3] = x;
                    _corners[1, 3] = y;
                    //Правый нижний на y
                    _corners[1, 2] = y;
                    //Левый верхний на х
                    _corners[0, 0] = x;
                    break;
            }
        }

        public void ResetCorners()
        {
            double xMin = double.MaxValue;
            double yMin = double.MaxValue;
            double xMax = double.MinValue;
            double yMax = double.MinValue;
            for (int i = 0; i < 4; i++)
            {
                if (_corners[0, i] > xMax)
                {
                    xMax = _corners[0, i];
                }

                if (_corners[0, i] < xMin)
                {
                    xMin = _corners[0, i];
                }
                if (_corners[1, i] > yMax)
                {
                    yMax = _corners[1, i];
                }

                if (_corners[1, i] < yMin)
                {
                    yMin = _corners[1, i];
                }
            }
            //Переназначить индексы углов
            _corners[0, 0] = xMin;
            _corners[0, 1] = xMax;
            _corners[0, 2] = xMax;
            _corners[0, 3] = xMin;
            _corners[1, 0] = yMax;
            _corners[1, 1] = yMax;
            _corners[1, 2] = yMin;
            _corners[1, 3] = yMin;
        }

        public virtual void MoveObj(double dx, double dy)
        {
            for (int i = 0; i < 4; i++)
            {
                _corners[0, i] += dx;
                _corners[1, i] += dy;
            }
        }

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
            _selected = 
                _corners[1, 0] >= rdY &&
                _corners[1, 2] <= luY &&
                _corners[0, 2] >= luX &&
                _corners[0, 0] <= rdX;
        }

        public FigureAbstract Clone()
        {
            _corners = new double[2, 4];
            return (FigureAbstract)MemberwiseClone();
        }

        public virtual void PlaceFigure(double x, double y)
        {
            _corners[0, 0] = _corners[0, 1] = _corners[0, 2] = _corners[0, 3] = x;
            _corners[1, 0] = _corners[1, 1] = _corners[1, 2] = _corners[1, 3] = y;
            _selectedPoint = 2;
        }

        public bool SelectPoint(double x, double y)
        {
            double e = 2.0;
            for (int i = 0; i < 4; i++)
            {
                if (Math.Sqrt((x - _corners[0, i]) * (x - _corners[0, i]) + (y - _corners[1, i]) * (y - _corners[1, i])) <= e)
                {
                    _selectedPoint = i;
                    return true;
                }
            }
            return false;
        }

        public void SelectFigure(double x, double y)
        {
            _selected = _corners[1, 3] <= y && _corners[1, 1] >= y && _corners[0, 3] >= x && _corners[0, 1] <= x;
        }

        protected abstract void _Drawer(int[,] Corners, Graphics g);

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}
