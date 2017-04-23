using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOP3
{
    class FigureController
    {
        private PictureClass _picture;
        private List<IFactoryAbstract> _factories;
        private List<FigureAbstract> _figures;


        public FigureController(Panel Canvas)
        {
            _factories = new List<IFactoryAbstract>();
            _figures = new List<FigureAbstract>();
            _picture = new PictureClass(Canvas);
            _factories.Add(new FactoryEllipse(_picture));
            _factories.Add(new FactoryLine(_picture));
            _factories.Add(new FactoryRectangle(_picture));
        }

        public void CreateFigure(int Type)
        {
            _figures.Add(_factories[Type].CreateFigure());
        }

        public void FindFigure(int X, int Y)
        {
            Tuple<double, double> T = _picture.GetPoint(X, Y);
            for (int i = _figures.Count - 1; i >= 0; i--)
            {
                if (_figures[i].CursorIn(T.Item1, T.Item2))
                {
                    _figures[i].Selected = true;
                    for (int j = 0; j < _figures.Count; j++)
                    {
                        if (i != j)
                            _figures[j].Selected = false;
                    }
                }
            }
        }
    }
}
