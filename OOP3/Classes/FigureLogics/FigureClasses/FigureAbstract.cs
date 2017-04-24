﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    abstract class FigureAbstract : IFigure
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
        protected double _xCent, _yCent;

        protected PictureClass _picController;
        protected bool _selected;

        protected int _selectedPoint;

        public bool Selected { get { return _selected; } set { _selected = value; } }

        protected FigureAbstract(PictureClass PictureController)
        {
            _corners = new double[2, 4];
            _selected = false;
            _picController = PictureController;
        }

        public bool CursorIn(double X, double Y)
        {
            double Eps = 2.0;
            return (_corners[0, 0] - Eps <= X) && (X <= _corners[0, 2] + Eps) &&
                    (_corners[1, 0] - Eps <= Y) && (Y <= _corners[1, 2] + Eps);
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
        public void ChangeSize(double x, double y)
        {
            switch (_selectedPoint)
            {
                //Взяли верхний левый угол
                //Не изменяется нижний правый
                case 0:
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

            _xCent = x;
            _yCent = y;
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
    }
}
