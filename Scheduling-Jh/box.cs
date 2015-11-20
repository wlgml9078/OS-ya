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
        Panel[] graphs;
        bool is_down;
        Point position;
        private int currentPosition;
        List<Process> list;
        public box()
        {
            
            position = new Point();
            InitializeComponent();
            currentPosition = 0;
            is_down = false;
        }
        public void setBox(List<Process> list){
            this.list = list;
            graphs = new Panel[list.Count];
        }

        public void drawGhanttChart() {
            for (int i = 0; i<list.Count;i++ )
            {


            }
        }
        public void getInfo(){

        }
        private void box_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            position.X = e.X;
            position.Y = e.Y;
            is_down = true;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            position.X = e.X;
            position.Y = e.Y;
            is_down = true;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            is_down = false;
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            is_down = false;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (is_down)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - position.X, p.Y - position.Y);
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (is_down)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - position.X, p.Y - position.Y);
            }
        }
    }
}
