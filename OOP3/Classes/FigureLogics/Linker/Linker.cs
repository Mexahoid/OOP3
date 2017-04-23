using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    class Linker : FigureAbstract, IFigure
    {
        private List<FigureAbstract> _figures;

        public Linker(List<FigureAbstract> Figures, PictureClass pic) : base(pic) 
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
    }
}
