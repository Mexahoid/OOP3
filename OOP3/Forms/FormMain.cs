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
        private ColorScheme _currentColorScheme;

        public MainForm()
        {
            InitializeComponent();
            CtrlLBDashStyles.SelectedIndex = 0;
            _currentColorScheme = new ColorScheme();
            _currentColorScheme.Init();
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint, true);
        }

        private void CtrlTSMINew_Click(object sender, EventArgs e)
        {
            int[] Dims = new int[2];
            using (FormNew FN = new FormNew(Dims))
            {
                if (FN.ShowDialog() == DialogResult.OK)
                {
                    CtrlPanelMain.Width = Dims[1];
                    CtrlPanelMain.Height = Dims[0];
                    CtrlPanelMain.Enabled = true;
                    CtrlTSMISave.Enabled = true;
                    _controller = new FigureController(new PictureClass(CtrlPanelMain));
                    _controller.CurrentColorScheme = _currentColorScheme;
                }
            }
        }

        private void CtrlTSMISave_Click(object sender, EventArgs e)
        {
            if (_controller != null)
                using (SaveFileDialog SFD = new SaveFileDialog())
                    if (SFD.ShowDialog() == DialogResult.OK)
                        _controller.Save(SFD.FileName);
        }

        private void CtrlTSMIClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CtrlPanelMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (_controller != null)
                _controller.Action_MouseMove(e.X, e.Y);
        }

        private void CtrlPanelMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (_controller != null)
                _controller.Action_MouseDown(e.X, e.Y);
        }

        private void CtrlPanelMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (_controller != null)
                _controller.Action_MouseUp(e.X, e.Y);
        }

        private void CtrlButTool_Click(object sender, EventArgs e)
        {
            if (_controller != null)
                _controller.ToolIndex = Convert.ToInt32((sender as Button).Tag);
        }

        private void CtrlButSpecial_Click(object sender, EventArgs e)
        {
            if (_controller != null)
            {
                _controller.SpecialIndex = Convert.ToInt32((sender as Button).Tag);
                _controller.Action_Special();
            }
        }

        private void ColorChange(object sender, EventArgs e)
        {
            if (_controller != null)
            {
                if (sender.GetType() == typeof(Button))
                    using (ColorDialog CD = new ColorDialog())
                    {
                        if (CD.ShowDialog() == DialogResult.OK)
                        {
                            if ((sender as Control).Tag.Equals("0"))
                            {
                                CtrlButColFG.BackColor = CD.Color;
                                _currentColorScheme["FGColor"] = CD.Color;
                            }
                            else
                            {
                                CtrlButColBG.BackColor = CD.Color;
                                _currentColorScheme["BGColor"] = CD.Color;
                            }
                        }
                    }
                _currentColorScheme["Dashes"] = CtrlLBDashStyles.SelectedIndex;
                _currentColorScheme["Width"] = (int)CtrlNudWidth.Value;
                _controller.CurrentColorScheme = _currentColorScheme;
            }
        }
    }
}
