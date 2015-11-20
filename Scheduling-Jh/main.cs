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
        private bool is_down;
        private Point position;
        private box chlid;
        private List<Process> processListval;
        private List<Stamp> timestamp;
        int target_scheduler;
        public main()
        {
            InitializeComponent();
            chlid = new box();
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            processListval=new List<Process>();
            timeSlice.Hide();
            timeSliceText.Hide();
            priority.Hide();
            priorityText.Hide();
            is_down = false;
            target_scheduler = 0;
            
            
        }       
        private List<Process> getData() {
            return processListval;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            chlid.SetBounds(Location.X+665,Location.Y,350,507);
            chlid.Show();           
            switch (target_scheduler)
            {
                case 0:
                    FCFS fcfs=new FCFS(getData());
                    timestamp = fcfs.getTimestamp();
                    fcfs.fcfs_run();
                    for (int i = 0; i < timestamp.Count; i++)
                    {
                        timestamp[i].print();
                    }
                    Console.WriteLine(System.Convert.ToDouble(fcfs.getAWT()) + " " +System.Convert.ToDouble(fcfs.getATT()));
                    break;
                case 5:
                    if(timeSlice.Text==""){
                        timeSliceText.ForeColor=Color.Red;
                    }
                    else{
                        int quant;
                        Int32.TryParse(timeSlice.Text,out quant);
                        RR rr=new RR(getData(), quant);
                        //Console.WriteLine("before run");
                        rr.rr_alg();
                        //Console.WriteLine("after run");
                        timestamp = rr.getTimestamp();
                        for(int i = 0; i < timestamp.Count; i++)
                        {
                            timestamp[i].print();
                        }
                        Console.WriteLine(rr.getAWT()+" "+rr.getATT());
                        
                    }
                    break;
                default:
                    break;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                target_scheduler = 6;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton6.Checked)
            {
                target_scheduler = 3;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                target_scheduler = 4;
            }
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                target_scheduler = 5;
                timeSlice.Show();
                timeSliceText.Show();
                
            }
            else
            {
                
                timeSlice.Hide();
                timeSliceText.Hide();
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                target_scheduler = 2;
                priority.Show();
                priorityText.Show();
            }
            else
            {
                priority.Hide();
                priorityText.Hide();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                target_scheduler = 1;
                priority.Show();
                priorityText.Show();
                
            }
            else
            {
                priority.Hide();
                priorityText.Hide();
            }
        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                target_scheduler = 0;
            }
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        

        private void arrivalTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자,백스페이스,마이너스,소숫점 만 입력받는다.
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8 && e.KeyChar != 45 && e.KeyChar != 46) //8:백스페이스,45:마이너스,46:소수점
            {
                e.Handled = true;
            }
        }

        private void burstTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자,백스페이스,마이너스,소숫점 만 입력받는다.
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8 && e.KeyChar != 45 && e.KeyChar != 46) //8:백스페이스,45:마이너스,46:소수점
            {
                e.Handled = true;
            }
        }

        private void priority_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자,백스페이스,마이너스,소숫점 만 입력받는다.
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8 && e.KeyChar != 45 && e.KeyChar != 46) //8:백스페이스,45:마이너스,46:소수점
            {
                e.Handled = true;
            }
        }

        private void timeSlice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자,백스페이스,마이너스,소숫점 만 입력받는다.
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8 && e.KeyChar != 45 && e.KeyChar != 46) //8:백스페이스,45:마이너스,46:소수점
            {
                e.Handled = true;
            }
        }
        private void addProcessToList(bool flag)
        {
            int temp1,temp2,temp3;
            Process newProcess;
            String name;
            if (processName.Text == "")
                name = (processListval.Count + 1) + "";

            else
                name = processName.Text;
            Int32.TryParse(arrivalTime.Text,out temp1);
            Int32.TryParse(burstTime.Text,out temp2);
            if (flag){
                newProcess = new Process(name, temp1,temp2);
                processList.Rows.Add(newProcess.getName(), newProcess.getArrivalTime(), newProcess.getBurstTime(), 0 + "");
            }
            else
            {
                Int32.TryParse(priority.Text, out temp3);
                newProcess = new Process(name, temp1, temp2,temp3);
                processList.Rows.Add(newProcess.getName(), newProcess.getArrivalTime(), newProcess.getBurstTime(), priority.Text);
                priority.Text = "";
                
            }
            processListval.Add(newProcess);
            processName.Text = "";
            arrivalTime.Text = "";
            burstTime.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            if(arrivalTime.Text==""){
                Console.WriteLine("arrival Null");
                arrivalTimeText.ForeColor = Color.Red;
            }
            else
            {
                arrivalTimeText.ForeColor = Color.Black;
                if(burstTime.Text=="")
                {
                    burstTimeText.ForeColor = Color.Red;
                }
                else
                {
                    burstTimeText.ForeColor = Color.Black;
                    if (radioButton2.Checked || radioButton3.Checked)
                    {
                        if (priority.Text == "")
                        {
                            priorityText.ForeColor = Color.Red;
                        }
                        else
                        {
                            priorityText.ForeColor = Color.Black;
                            addProcessToList(true);
                        }
                    }
                    else
                    {
                        addProcessToList(false);
                    }
                }
            }
            
        }

        private void processList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            is_down = true;
            position.X = e.X;
            position.Y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (is_down)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - position.X, p.Y - position.Y);
                //Location.X = e.Location.X - position.X;
                //Location.Y = e.Location.Y - position.Y;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            is_down = false;
        }

        private void processList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random r=new Random();
            Process newProcess;
            arrivalTime.Text = "";
            burstTime.Text = "";
            priority.Text = "";
            processName.Text = "";
            int temp1=r.Next(0,10);
            int temp2=r.Next(0,10);
            int temp3=r.Next(0,10);

            if (radioButton2.Checked || radioButton3.Checked)
            {
                newProcess= new Process(processListval.Count+1+"",temp1,temp2,temp3);
                processList.Rows.Add(newProcess.getName(), newProcess.getArrivalTime(), newProcess.getBurstTime(), priority.Text);
            }
            else
            {
                newProcess = new Process(processListval.Count + 1 + "", temp1, temp2);
                processList.Rows.Add(newProcess.getName(), newProcess.getArrivalTime(), newProcess.getBurstTime());
            }
            processListval.Add(newProcess);
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            is_down = true;
            position.X = e.X;
            position.Y = e.Y;
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            if (is_down)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - position.X, p.Y - position.Y);
            }
        }

        private void panel5_MouseUp(object sender, MouseEventArgs e)
        {
            is_down = false;
        }

        
        

        
    }
}
