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
        private Rectangle[] graphs;
        bool is_down;
        Point position;
        private int currentPosition;        //현재 진행중인 stamp 번호
        private List<Stamp> stmp_list;      //스탬프 리스트
        private List<Process> pro_list;     //프로세스 리스트
        bool draw = true;

        public box(List<Process> list)
        {
            this.pro_list = list;
            InitializeComponent();
            this.stmp_list = new List<Stamp>();
            position = new Point();
            currentPosition = 0;
            is_down = false;
            
        }
        public void setStamp(List<Stamp> list){
            stmp_list = list;
            graphs = new Rectangle[list.Count];
                //Console.WriteLine("stampsize=" + list.Count);
        }
        //그릴 함수
        public void drawAutoGhanttChart(object sender, PaintEventArgs e) 
        {
            if (draw)
            {
                Graphics g = Ghannt_base.CreateGraphics();
                Random r = new Random();
                Brush[] brush = new SolidBrush[pro_list.Count];
                Pen p;
                
                Point startPoint = new Point();
                int max_end = 0;
                for (int i = 0; i < pro_list.Count; i++)
                {
                    //최대 프로세스 종료 시간을 구한다.
                    max_end = (max_end > pro_list[i].getEndTime() ? max_end : pro_list[i].getEndTime());
                    //같은 반복문 내에서 브러시를 만든다
                    int red = r.Next(0, 100), green = r.Next(0, 100), blue = r.Next(0, 100);
                    brush[i] = new SolidBrush(Color.FromArgb(0, red, green, blue));
                }
                    //Console.WriteLine("MAX: " + max_end);


                startPoint.X = (Ghannt_base.Location.X);
                startPoint.Y = (Ghannt_base.Location.Y);
                    //Console.WriteLine(stmp_list.Count);
                for (; currentPosition < stmp_list.Count; currentPosition++)
                {

                    int index = 0;
                    for (int j = 0; j < pro_list.Count; j++)
                    {
                        if ((String.Compare(pro_list[j].getName(), stmp_list[currentPosition].getName()) == 0))
                        {
                            index = j;
                            break;
                        }
                    }
                    //get width in pixel
                        //Console.WriteLine(stmp_list[currentPosition].getTimeGap() + "");
                    double width = (stmp_list[currentPosition].getTimeGap() * 640) / max_end;
                        //Console.WriteLine("Location: " + startPoint.X + "  " + startPoint.Y+" width: " +width);

                    graphs[currentPosition] = new Rectangle(new Point(startPoint.X, startPoint.Y), new Size((int)width, 51));

                    //(brush, graphs[i]);
                    p = new Pen(brush[index], 4);
                    g.DrawRectangle(p, graphs[currentPosition]);
                    //startPoint = new Point(startPoint.X + (int)width, startPoint.Y);
                    startPoint.X += (int)width;

                }
                draw = false;
            }
        }
        public void getInfo(){

        }
        private void box_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
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
        
        private void Ghannt_base_Paint(object sender, PaintEventArgs e)
        {
            if (draw)
            {
                Graphics g = e.Graphics;
                Random r = new Random();
                Brush[] brush = new SolidBrush[pro_list.Count];
                Pen p;

                Point startPoint = new Point();
                int max_end = 0;
                for (int i = 0; i < pro_list.Count; i++)
                {
                    //최대 프로세스 종료 시간을 구한다.
                    max_end = (max_end > pro_list[i].getEndTime() ? max_end : pro_list[i].getEndTime());
                    //같은 반복문 내에서 브러시를 만든다
                    int red = r.Next(0, 100), green = r.Next(0, 100), blue = r.Next(0, 100);
                    brush[i] = new SolidBrush(Color.FromArgb(0, red, green, blue));
                    //brush[0] = new SolidBrush(Color.Red);
                    //brush[1] = new SolidBrush(Color.Blue);
                    
                }
                    //Console.WriteLine("MAX: " + max_end);


                startPoint.X = (Ghannt_base.Location.X);
                startPoint.Y = (Ghannt_base.Location.Y);
                    //Console.WriteLine(stmp_list.Count);
                for (; currentPosition < stmp_list.Count; currentPosition++)
                {

                    int index = 0;
                    for (int j = 0; j < pro_list.Count; j++)
                    {
                        if ((String.Compare(pro_list[j].getName(), stmp_list[currentPosition].getName()) == 0))
                        {
                            index = j;
                            break;
                        }
                    }
                    //get width in pixel
                        //Console.WriteLine(stmp_list[currentPosition].getTimeGap() + "");
                    double width = (stmp_list[currentPosition].getTimeGap() * 640) / max_end;
                        //Console.WriteLine("Location: " + startPoint.X + "  " + startPoint.Y + " width: " + width);

                    graphs[currentPosition] = new Rectangle(new Point(startPoint.X, startPoint.Y), new Size((int)width, 51));

                        //(brush, graphs[i]);
                    p = new Pen(brush[index], graphs[currentPosition].Width);
                    g.DrawRectangle(p, graphs[currentPosition]);
                    Ghannt_base.Refresh();
                        //startPoint = new Point(startPoint.X + (int)width, startPoint.Y);
                    startPoint.X += (int)width;

                }
                p = new Pen(brush[0]);
                draw = false;
            }
        }

        private void box_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void Ghantt_Chart_draw(object sender, PaintEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ghannt_base.Paint += new PaintEventHandler(drawAutoGhanttChart);
            Ghannt_base.Refresh();
        }
    }
}
