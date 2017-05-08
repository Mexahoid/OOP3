using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace OOP3
{
    public struct ColorScheme
    {
        public Color ColorBackground;
        public Color ColorForeground;
        public DashStyle[] Dashes;
        public HatchStyle[] Hatches;
        public int SelectedFillIndex;
        public int SelectedDashIndex;
        public int Width;

        public Brush GetBrush()
        {
            if (SelectedFillIndex == 0)
                return new SolidBrush(ColorBackground);
            else
                return new HatchBrush(Hatches[SelectedFillIndex], ColorForeground, ColorBackground);
        }

        public Pen GetPen()
        {
            Pen Out = new Pen(ColorForeground, Width);
            Out.DashStyle = Dashes[SelectedDashIndex];
            return Out;
        }
    }
}
