using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    interface IFactory
    {
        FigureAbstract CreateFigure();
    }
}
