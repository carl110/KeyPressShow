using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyPressShow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Up)
            {
                pbxUp.Image = Image.FromFile("keyUp.png");
                return true;
            }
            if (keyData == Keys.Down)
            {
                pbxDown.Image = Image.FromFile("keyDown.png");
                return true;
            }
            if (keyData == Keys.Left)
            {
                pbxLeft.Image = Image.FromFile("keyLeft.png");
                return true;
            }
            if (keyData == Keys.Right)
            {
                pbxRight.Image = Image.FromFile("keyRight.png");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                pbxUp.Image = null;
            }
            if (e.KeyCode == Keys.Down)
            {
                pbxDown.Image = null;
            }
            if (e.KeyCode == Keys.Left)
            {
                pbxLeft.Image = null;
            }
            if (e.KeyCode == Keys.Right)
          {
                pbxRight.Image = null;
            }

        }
    }
}
