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
        private List<IFactory> _factories;
        private List<FigureAbstract> _figures;
        private int _toolIndex = -1;
        private int _selectedFigureIndex = -1;
        private Tuple<double, double> _PrevPos;

        public int ToolIndex { get => _toolIndex; set => _toolIndex = value; }

        public FigureController(Panel Canvas)
        {
            _factories = new List<IFactory>();
            _figures = new List<FigureAbstract>();
            _picture = new PictureClass(Canvas);
            _factories.Add(new FactoryEllipse(_picture));
            _factories.Add(new FactoryLine(_picture));
            _factories.Add(new FactoryRectangle(_picture));
        }

        public void CreateFigure(int x, int y)
        {
            if (_toolIndex != -1)
            {
                _figures.Add(_factories[_toolIndex].CreateFigure());
                _PrevPos = _picture.GetPoint(x, y);
                _figures[_figures.Count - 1].PlaceFigure(_PrevPos.Item1, _PrevPos.Item2);
                _figures[_figures.Count - 1].Selected = true;
            }
        }

        public void FigureSize(int x, int y)
        {
            if (_toolIndex != -1)
            {
                _PrevPos = _picture.GetPoint(x, y);
                _figures[_figures.Count - 1].ChangeSize(_PrevPos.Item1, _PrevPos.Item2);
            }
        }

        public void ResetCorners()
        {
            _picture.Clear();
            int C = _figures.Count;
            for (int i = 0; i < C; i++)
            {
                _figures[i].ResetCorners();
            }
        }

        public void FindFigure(int X, int Y)
        {
            for (int i = _figures.Count - 1; i >= 0; i--)
            {
                if (_figures[i].CursorIn(_PrevPos.Item1, _PrevPos.Item2))
                {
                    _figures[i].Selected = true;
                    _selectedFigureIndex = i;
                    for (int j = 0; j < _figures.Count; j++)
                    {
                        if (i != j)
                            _figures[j].Selected = false;
                    }
                }
            }
        }

        public void Action_MouseDown(int X, int Y)
        {
            _PrevPos = _picture.GetPoint(X, Y);
            if (_toolIndex == -1)
            {
                FindFigure(X, Y);
                Draw();
            }
            else
            {
                _Deselect();
                CreateFigure(X, Y);
            }
        }

        public void Action_MouseMove(int X, int Y)
        {
            Tuple<double, double> T = _picture.GetPoint(X, Y);
            if (_toolIndex == -1)
            {
                
                _figures[_selectedFigureIndex].MoveObj(
                    -_PrevPos.Item1 + T.Item1,
                    - _PrevPos.Item2 + T.Item2);
            }
            else
            {
                FigureSize(X, Y);
            }
            _PrevPos = T;
        }

        private void _MoveFigure()
        {

        }

        private void _Deselect()
        {
            int C = _figures.Count;
            for (int i = 0; i < C; i++)
            {
                _figures[i].Selected = false;
            }
        }

        public void Draw()
        {
            _picture.Clear();
            int C = _figures.Count;
            for (int i = 0; i < C; i++)
            {
                _figures[i].Draw();
            }
        }
    }
}
