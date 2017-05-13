using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OOP3
{
    class FigureLine : FigureAbstract
    {
        private int _from, _to;

        public FigureLine(PictureClass pic, ColorScheme ColorScheme) : base(pic, ColorScheme)
        {

        }

        public override void Draw()
        {
            _picController.DrawFigure(_Drawer, _corners);
        }

        public override void PlaceFigure(double x, double y)
        {
            _corners[0, 0] = _corners[0, 1] = _corners[0, 2] = _corners[0, 3] = x;
            _corners[1, 0] = _corners[1, 1] = _corners[1, 2] = _corners[1, 3] = y;
            _from = _selectedPoint = 0;
            _to = 2;
        }

        public override void ChangeSize(double x, double y)
        {
            switch (_from)
            {
                case 0:
                    if (_corners[0, 2] < _corners[0, 0] && _corners[1, 2] > _corners[1, 0])
                    {
                        _to = 0;
                        _from = 2;
                    }
                    else
                    {
                        if (_corners[0, 2] < _corners[0, 0])
                        {
                            _to = 3;
                            _from = 1;
                        }
                        if (_corners[1, 2] > _corners[1, 0])
                        {
                            _to = 1;
                            _from = 3;
                        }
                    }
                    break;
                case 1:
                    if (_corners[0, 3] > _corners[0, 1] && _corners[1, 3] > _corners[1, 1])
                    {
                        _to = 1;
                        _from = 3;
                    }
                    else
                    {
                        if (_corners[0, 3] > _corners[0, 1])
                        {
                            _to = 2;
                            _from = 0;
                        }
                        if (_corners[1, 3] > _corners[1, 1])
                        {
                            _to = 0;
                            _from = 2;
                        }
                    }
                    break;
                case 2:
                    if (_corners[0, 0] > _corners[0, 2] && _corners[1, 2] > _corners[1, 0])
                    {
                        _to = 2;
                        _from = 0;
                    }
                    else
                    {
                        if (_corners[0, 0] > _corners[0, 2])
                        {
                            _to = 1;
                            _from = 3;
                        }
                        if (_corners[1, 2] > _corners[1, 0])
                        {
                            _to = 3;
                            _from = 1;
                        }
                    }
                    break;
                case 3:
                    if (_corners[0, 1] < _corners[0, 3] && _corners[1, 3] > _corners[1, 1])
                    {
                        _to = 3;
                        _from = 1;
                    }
                    else
                    {
                        if (_corners[0, 1] < _corners[0, 3])
                        {
                            _to = 0;
                            _from = 2;
                        }
                        if (_corners[1, 3] > _corners[1, 1])
                        {
                            _to = 2;
                            _from = 0;
                        }
                    }
                    break;
            }
            base.ChangeSize(x, y);
        }

        protected override void _Drawer(int[,] Corners, Graphics g)
        {
            if (_selected)
                g.DrawRectangle(Pens.LightGray, Corners[0, 0], Corners[1, 0] - 0,
                    Math.Abs(Corners[0, 2] - Corners[0, 0]), Math.Abs(Corners[1, 2] - Corners[1, 0]));
            g.DrawLine(_cc.GetPen(), Corners[0, 3 - _from], Corners[1, 3 - _from], Corners[0, 3 - _to], Corners[1, 3 -_to]);
        }

        public override void Save(ref string Text)
        {
            Text += "<line" +
                " x1=\"" + _corners[0, _from] + "\"" +
                " y1=\"" + _corners[1, _from] + "\"" +
                " x2=\"" + _corners[0, _to] + "\"" +
                " y2=\"" + _corners[1, _to] + "\"" +
                " style=\"" +
                _cc["Width"] + '\n' +
                _cc["FGColor"] + '\n' +
                _cc["Dashes"] + '\n' +
                "\"/>\n";
        }
    }
}
