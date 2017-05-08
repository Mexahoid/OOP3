using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOP3
{
    public partial class MainForm : Form
    {
        private FigureController _controller;
        private PictureClass _picture;
        private ColorScheme _currentColorScheme;

        public MainForm()
        {
            InitializeComponent();

            _currentColorScheme = new ColorScheme();
            _currentColorScheme.Hatches = (HatchStyle[])Enum.GetValues(typeof(HatchStyle));
            _currentColorScheme.Dashes = (DashStyle[])Enum.GetValues(typeof(DashStyle));
            _currentColorScheme.ColorBackground = Color.White;
            _currentColorScheme.ColorForeground = Color.Black;
            _currentColorScheme.Width = 1;
            CtrlLBFillStyles.SelectedIndex = CtrlLBDashStyles.SelectedIndex = 0;
            _picture = new PictureClass(CtrlPanelMain);
            _picture.CurrentColorScheme = _currentColorScheme;
            _controller = new FigureController(_picture);
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint, true);
        }

        private void CtrlTSMINew_Click(object sender, EventArgs e)
        {

        }

        private void CtrlTSMIOpen_Click(object sender, EventArgs e)
        {

        }

        private void CtrlTSMISave_Click(object sender, EventArgs e)
        {

        }

        private void CtrlTSMIClose_Click(object sender, EventArgs e)
        {

        }

        private void CtrlTSMILoadFigures_Click(object sender, EventArgs e)
        {

        }

        private void CtrlPanelMain_MouseMove(object sender, MouseEventArgs e)
        {
            _controller.Action_MouseMove(e.X, e.Y);
        }

        private void CtrlPanelMain_MouseDown(object sender, MouseEventArgs e)
        {
            _controller.Action_MouseDown(e.X, e.Y);
        }

        private void CtrlPanelMain_MouseUp(object sender, MouseEventArgs e)
        {
            _controller.Action_MouseUp(e.X, e.Y);
        }

        private void CtrlButTool_Click(object sender, EventArgs e)
        {
            _controller.ToolIndex = Convert.ToInt32((sender as Button).Tag);
        }

        private void CtrlButSpecial_Click(object sender, EventArgs e)
        {
            _controller.SpecialIndex = Convert.ToInt32((sender as Button).Tag);
            _controller.Action_Special();
        }

        private void StyleChange(object sender, EventArgs e)
        {
            _currentColorScheme.SelectedFillIndex = CtrlLBFillStyles.SelectedIndex;
        }

        private void ColorChange(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Button))
                using (ColorDialog CD = new ColorDialog())
                {
                    if (CD.ShowDialog() == DialogResult.OK)
                    {
                        if ((sender as Control).Tag.Equals("0"))
                            CtrlButColFG.BackColor = _currentColorScheme.ColorForeground = CD.Color;
                        else
                            CtrlButColBG.BackColor = _currentColorScheme.ColorBackground = CD.Color;
                    }
                }
            _currentColorScheme.SelectedFillIndex = CtrlLBFillStyles.SelectedIndex;
            _currentColorScheme.SelectedDashIndex = CtrlLBDashStyles.SelectedIndex;
            _currentColorScheme.Width = (int)CtrlNudWidth.Value;
            _picture.CurrentColorScheme = _currentColorScheme;
        }
    }
}
