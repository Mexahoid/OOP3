using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace OOP3
{
    public static class Sas
    {
        public static string GetName(this Color cl)
        {
            string Before = cl.Name;
            if (Before.IndexOfAny(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }) != -1)
                return "#" + Before;
            return Before;
        }
    }
    public struct ColorScheme
    {
        private Color _colorBackground;
        private Color _colorForeground;
        private DashStyle[] _dashes;
        private HatchStyle[] _hatches;
        private int _selectedFillIndex;
        private int _selectedDashIndex;
        private int _width;
        

        public Brush GetBrush()
        {
            if (_selectedFillIndex == 0)
                return new SolidBrush(_colorBackground);
            else
                return new HatchBrush(_hatches[_selectedFillIndex], _colorForeground, _colorBackground);
        }

        public void Init()
        {
            _hatches = (HatchStyle[])Enum.GetValues(typeof(HatchStyle));
            _dashes = (DashStyle[])Enum.GetValues(typeof(DashStyle));
            _colorBackground = Color.White;
            _colorForeground = Color.Black;
            _width = 1;
        }

        public Pen GetPen()
        {
            Pen Out = new Pen(_colorForeground, _width);
            Out.DashStyle = _dashes[_selectedDashIndex];
            return Out;
        }

        public object this[string item]
        {
            get
            {
                switch (item)
                {
                    case "FGColor":  //Цвет обводки
                        return " stroke=\"" + _colorForeground.GetName().ToLower() + "\"";
                    case "BGColor":  //Цвет заливки
                        return " fill=\"" + _colorBackground.GetName().ToLower() + "\"";
                    case "Dashes":   //Тип дэшей
                        switch (_selectedDashIndex)
                        {
                            case 0:
                                return "";
                            case 1:
                                return $"stroke-dasharray=\"{_width * 3}\"";
                            case 2:
                                return $"stroke-dasharray=\"{_width}\"";
                            case 3:
                                return $"stroke-dasharray=\"{_width * 3} {_width}\"";
                            case 4:
                                return $"stroke-dasharray=\"{_width * 3} {_width} {_width}\"";
                        }
                        return "";
                    case "Hatches":  //Тип заливки
                        return "";
                    case "Width":    //Ширина
                        return " stroke-width=\"" + _width + "\"";
                    default:
                        return "";
                }
            }
            set
            {
                switch (item)
                {
                    case "FGColor":  //Цвет обводки
                        _colorForeground = (Color)value;
                        break;
                    case "BGColor":  //Цвет заливки
                        _colorBackground = (Color)value;
                        break;
                    case "Dashes":   //Тип дэшей
                        _selectedDashIndex = (int)value;
                        break;
                    case "Hatches":  //Тип заливки
                        _selectedFillIndex = (int)value;
                        break;
                    case "Width":    //Ширина
                        _width = (int)value;
                        break;
                }
            }
        }
    }
}
