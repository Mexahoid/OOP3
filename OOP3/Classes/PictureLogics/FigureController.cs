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
        private Tuple<int, int> _PrevScreenPos;

        public int ToolIndex { get { return _toolIndex; } set { _toolIndex = value; } }

        public FigureController(Panel Canvas)
        {
            _factories = new List<IFactory>();
            _figures = new List<FigureAbstract>();
            _picture = new PictureClass(Canvas);
            _factories.Add(new FactoryEllipse(_picture));
            _factories.Add(new FactoryLine(_picture));
            _factories.Add(new FactoryRectangle(_picture));
            _factories.Add(new FactoryComplex(_picture));
        }

        private void _CreateFigure(int x, int y)
        {
            if (_toolIndex > -1)
            {
                _figures.Add(_factories[_toolIndex].CreateFigure());
                _PrevPos = _picture.GetPoint(x, y);
                _figures[_figures.Count - 1].PlaceFigure(_PrevPos.Item1, _PrevPos.Item2);
                _figures[_figures.Count - 1].Selected = true;
            }
        }

        private void _FigureSize(int x, int y)
        {
            if (_toolIndex > -1)
            {
                _PrevPos = _picture.GetPoint(x, y);
                _figures[_figures.Count - 1].ChangeSize(_PrevPos.Item1, _PrevPos.Item2);
            }
        }

        private void _ResetCorners()
        {
            _picture.Clear();
            int C = _figures.Count;
            for (int i = 0; i < C; i++)
            {
                _figures[i].ResetCorners();
            }
        }

        private void _FindFigure(int X, int Y)
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

        private void _FindFigureInArea(int X, int Y)
        {
            int C = _figures.Count;
            Tuple<double, double> LU = _picture.GetPoint(_PrevScreenPos);
            Tuple<double, double> RD = _picture.GetPoint(X, Y);
            double[,] _corners = new double[,]
            {
                {LU.Item1, LU.Item1, RD.Item1, RD.Item1 },
                {LU.Item2, LU.Item2, RD.Item2, RD.Item2 }
            };
            double xMin = double.MaxValue;
            double yMin = double.MaxValue;
            double xMax = double.MinValue;
            double yMax = double.MinValue;
            for (int i = 0; i < 4; i++)
            {
                if (_corners[0, i] > xMax)
                {
                    xMax = _corners[0, i];
                }

                if (_corners[0, i] < xMin)
                {
                    xMin = _corners[0, i];
                }
                if (_corners[1, i] > yMax)
                {
                    yMax = _corners[1, i];
                }

                if (_corners[1, i] < yMin)
                {
                    yMin = _corners[1, i];
                }
            }
            //Переназначить индексы углов
            _corners[0, 0] = xMin;
            _corners[0, 1] = xMax;
            _corners[0, 2] = xMax;
            _corners[0, 3] = xMin;
            _corners[1, 0] = yMax;
            _corners[1, 1] = yMax;
            _corners[1, 2] = yMin;
            _corners[1, 3] = yMin;
            
            List<FigureAbstract> Figures = new List<FigureAbstract>();
            for (int i = 0; i < C; i++)
            {
                _figures[i].IsInSelectionArea(
                    _corners[0, 0], _corners[1, 0],
                    _corners[0, 2], _corners[1, 2]);
               /* _figures[i].IsInSelectionArea(
                LD.Item1, RU.Item2,
                RU.Item1, LD.Item1);*/
                if (_figures[i].Selected)
                {
                    Figures.Add(_figures[i]);
                    _figures.RemoveAt(i--);
                    C--;
                }
            }
            FigureComplex NewCFg = _factories[3].CreateFigure() as FigureComplex;
            NewCFg.ComposeIn(Figures);
            _figures.Add(NewCFg);
        }

        private void _MoveFigure(Tuple<double, double> T)
        {
            if (_selectedFigureIndex != -1)
                _figures[_selectedFigureIndex].MoveObj(
                    -_PrevPos.Item1 + T.Item1,
                     -_PrevPos.Item2 + T.Item2);
        }

        private void _Deselect()
        {
            _selectedFigureIndex = -1;
            int C = _figures.Count;
            for (int i = 0; i < C; i++)
            {
                _figures[i].Selected = false;
            }
        }

        private void _Draw()
        {
            _picture.Clear();
            int C = _figures.Count;
            for (int i = 0; i < C; i++)
            {
                _figures[i].Draw();
            }
        }

        public void Action_MouseDown(int X, int Y)
        {
            _PrevScreenPos = new Tuple<int, int>(X, Y);
            _PrevPos = _picture.GetPoint(X, Y);
            _Deselect();
            if (_toolIndex == -1)
            {
                _FindFigure(X, Y);
                _Draw();
            }
            else
            {
                _CreateFigure(X, Y);
            }
        }

        public void Action_MouseMove(int X, int Y)
        {
            Tuple<double, double> T = _picture.GetPoint(X, Y);
            switch (_toolIndex)
            {
                case -1:
                    _MoveFigure(T);
                    _Draw();
                    break;
                case -2:
                    _Draw();
                    _picture.DrawSelection(_PrevScreenPos.Item1, _PrevScreenPos.Item2,
                        X, Y);
                    break;
                default:
                    _FigureSize(X, Y);
                    _Draw();
                    break;
            }
            _PrevPos = T;
        }

        public void Action_MouseUp(int X, int Y)
        {
            if (_toolIndex == -2)
            {
                if(_PrevScreenPos.Item1 != X || _PrevScreenPos.Item2 != Y)
                _FindFigureInArea(X, Y);
            }
            _Draw();
        }
    }
}
