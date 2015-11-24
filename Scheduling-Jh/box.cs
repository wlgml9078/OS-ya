using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Scheduling_Jh
{
    public partial class box : Form
    {
        main main;
        private Rectangle[] graphs;
        bool is_down;
        Point position;
        private int currentPosition;        //현재 진행중인 stamp 번호
        private List<Stamp> stmp_list;      //스탬프 리스트
        private List<Process> pro_list;     //프로세스 리스트
        bool draw = false;
        int targetPosition;
        bool is_run = false;
        public box(List<Process> list,main main)
        {
            this.main = main;
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
            for (int i = 0; i < list.Count; i++)
            {
                //Console.WriteLine("name:" + list[i].getName() + "arr:" + list[i].getStartTime() + "end:" + list[i].getEndTime());
                //Console.WriteLine("arr:" + stmp_list[i].getStartTime() + " burst:" + (stmp_list[i].getTimeGap()+stmp_list[i].getStartTime()));
            }
        }
        //그릴 함수
        public void drawAutoGhanttChart(object sender, PaintEventArgs e) 
        {
           
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
        private bool isExist(List<int>list,int target) {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == target) {
                    return true;
                }
            }
            return false;
        }
        
        private void Ghannt_base_Paint(object sender, PaintEventArgs e)
        {
            if (!is_run) 
            {
                if (draw)
                {
                    is_run = true;
                    List<int> log=new List<int>();
                    Graphics fg= ghattbox.CreateGraphics();
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
                        Console.WriteLine("pro_endTime: ["+i+"]" + pro_list[i].getEndTime());
                        //같은 반복문 내에서 브러시를 만든다
                        byte red = (byte)r.Next(100, 200), green = (byte)r.Next(100, 200), blue = (byte)r.Next(100, 200);
                        brush[i] = new SolidBrush(Color.FromArgb((byte)0xFF,red, green, blue));
                    }
                        //Console.WriteLine("MAX: " + max_end);


                    startPoint.X = (0);
                    startPoint.Y = (0);
                    fg.DrawString(0 + "", new Font("Microsoft Sans Serif", 8), Brushes.Black, new Point(startPoint.X, startPoint.Y + 58));
                    log.Add(0);
                    Console.WriteLine(stmp_list.Count);
                    if (targetPosition == -1) 
                    { 
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
                            startPoint.X = (((stmp_list[currentPosition].getStartTime()) * 664) / max_end);
                                       
                            //get width in pixel
                            double width = (stmp_list[currentPosition].getTimeGap() * 664) / max_end;
                            graphs[currentPosition] = new Rectangle(new Point(startPoint.X, startPoint.Y), new Size((int)width, 51));

                            //(brush, graphs[i]);
                            p = new Pen(brush[index], 5);
                            g.FillRectangle(brush[index],graphs[currentPosition]);
                            //startPoint = new Point(startPoint.X + (int)width, startPoint.Y);
                            g.DrawString(stmp_list[currentPosition].getName(), new Font("Microsoft Sans Serif", 12), Brushes.White, graphs[currentPosition]);
                            if (!isExist(log, stmp_list[currentPosition].getStartTime())) 
                            {
                                fg.DrawString(stmp_list[currentPosition].getStartTime() + "", new Font("Microsoft Sans Serif", 8), Brushes.Black, new Point(startPoint.X, startPoint.Y + 58));
                                log.Add(stmp_list[currentPosition].getStartTime());
                            }
                            if (!isExist(log, stmp_list[currentPosition].getEndTime()))
                            {
                                fg.DrawString(stmp_list[currentPosition].getEndTime() + "", new Font("Microsoft Sans Serif", 8), Brushes.Black, new Point(startPoint.X + (int)width, startPoint.Y + 58));
                                log.Add(stmp_list[currentPosition].getEndTime());
                            }
                            for (int i = 0; i < stmp_list.Count; i++ )
                            {
                                Console.WriteLine("!!!!" + stmp_list[i].getName());
                            }
                            Console.WriteLine("\n");
                                Thread.Sleep(500);
                        }
                        targetPosition = stmp_list.Count;
                    }
                    else//단계진행
                    {                    
                        for (; currentPosition < targetPosition; currentPosition++)
                        {
                            int index = 0;
                            for (int j = 0; j < targetPosition; j++)
                            {
                                if ((String.Compare(pro_list[j].getName(), stmp_list[currentPosition].getName()) == 0))
                                {
                                    index = j;
                                    break;
                                }
                            }
                            startPoint.X = (((stmp_list[currentPosition].getStartTime()) * 664) / max_end);


                            //get width in pixel
                            double width = (stmp_list[currentPosition].getTimeGap() * 664) / max_end;
                            graphs[currentPosition] = new Rectangle(new Point(startPoint.X, startPoint.Y), new Size((int)width, 51));


                            //(brush, graphs[i]);
                            p = new Pen(brush[index], 5);
                            g.FillRectangle(brush[index], graphs[currentPosition]);
                            //startPoint = new Point(startPoint.X + (int)width, startPoint.Y);
                            g.DrawString(stmp_list[currentPosition].getName(), new Font("Microsoft Sans Serif", 12), Brushes.White, graphs[currentPosition]);
                            if (!isExist(log, stmp_list[currentPosition].getStartTime()))
                            {
                                fg.DrawString(stmp_list[currentPosition].getStartTime() + "", new Font("Microsoft Sans Serif", 8), Brushes.Black, new Point(startPoint.X, startPoint.Y + 58));
                                log.Add(stmp_list[currentPosition].getStartTime());
                            }
                            if (!isExist(log, stmp_list[currentPosition].getEndTime()))
                            {
                                fg.DrawString(stmp_list[currentPosition].getEndTime() + "", new Font("Microsoft Sans Serif", 8), Brushes.Black, new Point(startPoint.X + (int)width, startPoint.Y + 58));
                                log.Add(stmp_list[currentPosition].getEndTime());
                            }
                        }
                    }
                    g.DrawString("" + max_end, new Font("Microsoft Sans Serif", 12), Brushes.Black, new Point(4, 53));
                    draw = false;
               
                }
                is_run = false;
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
            targetPosition = -1;
            currentPosition = 0;
            draw = true;
            Ghannt_base.Paint += new PaintEventHandler(drawAutoGhanttChart);
            Ghannt_base.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (targetPosition < stmp_list.Count) {
                currentPosition = 0;
                targetPosition++;
                draw = true;
                Ghannt_base.Paint += new PaintEventHandler(drawAutoGhanttChart);
                Ghannt_base.Refresh();
            }
            else
            {
                this.main.listBox1.Items.Insert(0, "프로세스의 끝입니다");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (targetPosition > 0)
            {
                currentPosition = 0;
                targetPosition--;
                draw = true;
                Ghannt_base.Paint += new PaintEventHandler(drawAutoGhanttChart);
                Ghannt_base.Refresh();
            }
            else
            {
                this.main.listBox1.Items.Insert(0, "프로세스의 처음입니다");
            }
        }
    }
}
