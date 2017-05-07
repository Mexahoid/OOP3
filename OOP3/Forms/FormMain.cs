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
        private bool _drawing;

        public MainForm()
        {
            InitializeComponent();
            _controller = new FigureController(CtrlPanelMain);
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
            if (_drawing)
            {
                _controller.Action_MouseMove(e.X, e.Y);
            }
        }

        private void CtrlPanelMain_MouseDown(object sender, MouseEventArgs e)
        {
            _controller.Action_MouseDown(e.X, e.Y);
            _drawing = true;
        }

        private void CtrlPanelMain_MouseUp(object sender, MouseEventArgs e)
        {
            _controller.Action_MouseUp(e.X, e.Y);
            _drawing = false;
        }

        private void CtrlButTool_Click(object sender, EventArgs e)
        {
            _controller.ToolIndex = Convert.ToInt32((sender as Button).Tag);
        }
    }
}
