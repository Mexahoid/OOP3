using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IFigure
    {
        void SelectionDraw(double x, double y);

        void MoveObj(double dx, double dy);

        void Draw();

        IFigure Clone();
    }
}
