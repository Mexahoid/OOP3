using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace FigureRectangleLib
{
    class FigureRectangle : IFigure
    {
        public FigureRectangle()
        {

        }

        public IFigure Clone()
        {
            return MemberwiseClone() as IFigure;
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }

        public void MoveObj(double dx, double dy)
        {
            throw new NotImplementedException();
        }

        public void SelectionDraw(double x, double y)
        {
            throw new NotImplementedException();
        }
    }
}
