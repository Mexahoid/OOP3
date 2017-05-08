using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OOP3
{
    class FigureComplex : FigureAbstract, IEnumerable<FigureAbstract>
    {
        private List<FigureAbstract> _figures;

        public FigureComplex(PictureClass pic) : base(pic) { }

        public override bool Selected
        {
            get { return base.Selected; }
            set
            {
                /*int C = _figures.Count;
                for (int i = 0; i < C; i++)
                {
                    _figures[i].Selected = value;
                }*/
                base.Selected = value;
            }
        }

        public void ComposeIn(List<FigureAbstract> Figures)
        {
            _figures = Figures;
            _ResetPoints();
        }

        private void _ResetPoints()
        {
            double xMax = double.MinValue;
            double yMax = double.MinValue;
            double xMin = double.MaxValue;
            double yMin = double.MaxValue;
            int C = _figures.Count;
            double[,] Temp;
            for (int j = 0; j < C; j++)
            {
                Temp = _figures[j].GetPoints();
                for (int i = 0; i < 4; i++)
                {
                    if (Temp[0, i] > xMax)
                    {
                        xMax = Temp[0, i];
                    }
                    if (Temp[0, i] < xMin)
                    {
                        xMin = Temp[0, i];
                    }
                    if (Temp[1, i] > yMax)
                    {
                        yMax = Temp[1, i];
                    }
                    if (Temp[1, i] < yMin)
                    {
                        yMin = Temp[1, i];
                    }
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

        public List<FigureAbstract> Decompose()
        {
            return _figures;
        }

        public override void MoveObj(double dx, double dy)
        {
            base.MoveObj(dx, dy);
            int C = _figures.Count;
            for (int i = 0; i < C; i++)
            {
                _figures[i].MoveObj(dx, dy);
            }
        }

        public override void Draw()
        {
            _picController.DrawFigure(_Drawer, _corners);
            int C = _figures.Count;
            for (int i = 0; i < C; i++)
            {
                _figures[i].Draw();
            }
        }

        public override void IsInSelectionArea(double luX, double luY, double rdX, double rdY)
        {
            base.IsInSelectionArea(luX, luY, rdX, rdY);
        }

        public IEnumerator<FigureAbstract> GetEnumerator()
        {
            int C = _figures.Count;
            for (int i = 0; i < C; i++)
            {
                yield return _figures[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<FigureAbstract>)this).GetEnumerator();
        }

        protected override void _Drawer(int[,] Corners, Graphics g)
        {
            if (_selected)
                g.DrawRectangle(Pens.LightGray, Corners[0, 0], Corners[1, 0] - 0, Math.Abs(Corners[0, 2] - Corners[0, 0]), Math.Abs(Corners[1, 2] - Corners[1, 0]));
        }
    }
}
