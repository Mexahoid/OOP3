using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOP3
{
    public partial class MainForm : Form
    {
        private FigureController _controller;

        public MainForm()
        {
            InitializeComponent();
            _controller = new FigureController(CtrlPanelMain, OnPaint);
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

        protected override void OnPaint(PaintEventArgs e)
        {
            _controller.Draw();
        }
    }
}
