using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    class FigureComplex : FigureAbstract, IFigure, IEnumerable<FigureAbstract>
    {
        private List<FigureAbstract> _figures;

        public FigureComplex(List<FigureAbstract> Figures, PictureClass pic) : base(pic) 
        {
            int C = Figures.Count;
            _figures = Figures;
            _points = 0;
            for (int i = 0; i < C; i++)
            {
                _FigureAdd(Figures[i]);
            }
            ResetPoints();
        }

        private void _FigureAdd(FigureAbstract Figure)
        {
            Tuple<List<double>, List<double>> Temp;
            Temp = Figure.GetPoints();
            int T = Temp.Item1.Count;
            for (int j = 0; j < T; j++)
            {
                _x.Add(Temp.Item1[j]);
                _y.Add(Temp.Item2[j]);
            }
            _points += T;
        }

        public void ComposeIn(FigureAbstract Figure)
        {
            _figures.Add(Figure);
            _FigureAdd(Figure);
            ResetPoints();
        }

        public List<FigureAbstract> Decompose()
        {
            return _figures;
        }

        public override void SelectionDraw(double x, double y)
        {
            throw new NotImplementedException();
        }

        public override void MoveObj(double dx, double dy)
        {
            throw new NotImplementedException();
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }

        public override void IsInSelectionArea(double luX, double luY, double rdX, double rdY)
        {
            base.IsInSelectionArea(luX, luY, rdX, rdY);
            int C = _figures.Count;
            for (int i = 0; i < C; i++)
            {
                _figures[i].Selected = true;
            }
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
    }
}
