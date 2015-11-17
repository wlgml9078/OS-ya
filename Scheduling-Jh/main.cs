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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("즐","안녕안녕");
        }

        private void btn1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("바이바이");
        }
    }
}
