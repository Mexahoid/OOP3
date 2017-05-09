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
    public partial class FormNew : Form
    {
        private int[] _dims;
        public FormNew(int[] Dims)
        {
            InitializeComponent();
            _dims = Dims;
        }

        private void CtrlButCreate_Click(object sender, EventArgs e)
        {
            _dims[0] = (int)CtrlNudHeight.Value;
            _dims[1] = (int)CtrlNudWidth.Value;
            Close();
        }

        private void CtrlButCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
