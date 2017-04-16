using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOP3
{
    public delegate void DrawerDelegate(List<int> X, List<int> Y, Graphics g);

    class PictureClass
    {
        private int I1 = 0;
        private int J1 = 0;
        private int I2, J2;
        private double xMin, yMin, xMax, yMax;
        private Graphics _canvas;

        public PictureClass(Panel panel)
        {
            _canvas = panel.CreateGraphics();
            I2 = panel.Width;
            J2 = panel.Height;
            xMin = -300 / 8F; xMax = 300 + 300 / 8F;
            int kx = Screen.PrimaryScreen.Bounds.Width;
            int ky = Screen.PrimaryScreen.Bounds.Height;
            yMax = ky * (xMax - xMin) / kx / 2F + 210 / 2F;
            yMin = -ky * (xMax - xMin) / kx / 2F + 210 / 2F;
        }

        public void Clear()
        {
            _canvas.Clear(Color.White);
        }

        public void DrawFigure(DrawerDelegate Del, List<double> X, List<double> Y)
        {
            int C = X.Count;
            List<int> XI = new List<int>(), YI = new List<int>();
            for (int i = 0; i < C; i++)
            {
                XI[i] = II(X[i]);
                YI[i] = JJ(Y[i]);
            }
            Del(XI, YI, _canvas);
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
            return xMin + (1D * I - I1) * (xMax - xMin) / (I2 - I1);
        }
        private double YY(int J)
        {
            return yMin + (1D * J - J1) * (yMax - yMin) / (J2 - J1);
        }

        public Tuple<double, double> GetPoint(int X, int Y)
        {
            return Tuple.Create(XX(X), YY(Y));
        }
    }
}
