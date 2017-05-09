using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOP3
{
    public delegate void DrawerDelegate(int[,] Corners, Graphics g);
    public delegate int XYIJ(double XY);

    class PictureClass
    {
        private int I1 = 0;
        private int J1 = 0;
        private int I2, J2;
        private double xMin, yMin, xMax, yMax;
        private Graphics _canvas;
        private Bitmap _tb;
        private Graphics _temp;

        public PictureClass(Panel panel)
        {
            _canvas = panel.CreateGraphics();
            I2 = panel.Width;
            J2 = panel.Height;
            _tb = new Bitmap(I2, J2);
            _temp = Graphics.FromImage(_tb);
            xMin = -300 / 8F; xMax = 300 + 300 / 8F;
            int kx = Screen.PrimaryScreen.Bounds.Width;
            int ky = Screen.PrimaryScreen.Bounds.Height;
            yMax = ky * (xMax - xMin) / kx / 2F + 210 / 2F;
            yMin = -ky * (xMax - xMin) / kx / 2F + 210 / 2F;
        }

        public void Clear()
        {
            _temp.Clear(Color.White);
        }

        public void DrawFigure(DrawerDelegate Del, double[,] Corners)
        {
            int[,] corners = new int[2, 4];
            for (int i = 0; i < 4; i++)
            {
                corners[0, i] = II(Corners[0, i]);
                corners[1, 3 - i] = JJ(Corners[1, i]);
            }
            Del(corners, _temp);
        }

        public void FinalDraw()
        {
            _canvas.DrawImage(_tb, 0, 0);
        }

        public void DrawSelection(int X0, int Y0, int X, int Y)
        {
            _canvas.DrawPolygon(new Pen(Color.Gray),
                new Point[]{
                new Point(X0, Y0),
                new Point(X, Y0),
                new Point(X, Y),
                new Point(X0, Y)});
            FinalDraw();
        }
        private int II(double x)
        {
            return I1 + (int)((x - xMin) * (I2 - I1) / (xMax - xMin));
        }
        private int JJ(double y)
        {
            return J1 + (int)((y - yMin) * (J2 - J1) / (yMax - yMin));
        }
        private double XX(int I)
        {
            return xMin + (I - I1) * (xMax - xMin) / (I2 - I1);
        }
        private double YY(int J)
        {
            return yMin + (J - J1) * (yMax - yMin) / (J2 - J1);
        }

        public Tuple<double, double> GetPoint(int X, int Y)
        {
            return Tuple.Create(XX(X), YY(Y));
        }
        public Tuple<double, double> GetPoint(Tuple<int, int> T)
        {
            return Tuple.Create(XX(T.Item1), YY(T.Item2));
        }
        public Tuple<int, int> GetDims()
        {
            return Tuple.Create(I2, J2);
        }
        public XYIJ GetDel(bool flag)
        {
            if (flag)
                return II;
            else
                return JJ;
        }
    }
}
