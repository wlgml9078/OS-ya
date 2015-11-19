using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Scheduling_Jh
{
    public partial class box : Form
    {
        public box()
        {
            InitializeComponent();
        }
        public void getInfo(){

        }
        private void box_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
