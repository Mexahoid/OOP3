using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    interface IFigure
    {
        void ChangeSize(double x, double y);

        void MoveObj(double dx, double dy);

        void Draw();

        /// <summary>
        /// Метод для проверки нахождения фигуры в регионе.
        /// </summary>
        /// <param name="luX">Х верхнего левого угла.</param>
        /// <param name="luY">Y верхнего левого угла.</param>
        /// <param name="rdX">X нижнего правого угла.</param>
        /// <param name="rdY">Y нижнего правого угла</param>
        void IsInSelectionArea(double luX, double luY, double rdX, double rdY);

        void PlaceFigure(double x, double y);

        FigureAbstract Clone();

        bool SelectPoint(double x, double y);

        void SelectFigure(double x, double y);

        ColorScheme CC { set; }
    }
}
