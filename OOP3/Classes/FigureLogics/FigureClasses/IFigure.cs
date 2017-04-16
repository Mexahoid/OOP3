using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    interface IFigure
    {
        void SelectionDraw(double x, double y);

        void MoveObj(double dx, double dy);

        void Draw();
    }
}
