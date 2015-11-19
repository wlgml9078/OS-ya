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
        private Point position,in_position;
        private TextBox textbox;
        private Button processNameval;
        private box chlid;
        private List<Process> processListval;
        bool[] radioChecks;
        public main()
        {
            InitializeComponent();
            chlid = new box();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioChecks=new bool[7];
            radioChecks[0] = radioButton1.Checked;
            radioChecks[1] = radioButton2.Checked;
            radioChecks[2] = radioButton3.Checked;
            radioChecks[3] = radioButton4.Checked;
            radioChecks[4] = radioButton5.Checked;
            radioChecks[5] = radioButton6.Checked;
            radioChecks[6] = radioButton7.Checked;
            processListval=new List<Process>();
            timeSlice.Hide();
            timeSliceText.Hide();
            priority.Hide();
            priorityText.Hide();
            is_down = false;
            
            
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
         
        }

        private void btn1_KeyDown(object sender, KeyEventArgs e)
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private List<Process> getData() {
            return processListval;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            chlid.Show();
            int target=0;
            for(int i=0;i<7;i++){
                if(radioChecks[i]){
                    target = i;
                    break;
                }
            }
            switch (target)
            {
                case 0:
                    new FCFS(getData());
                    break;
                case 5:
                    if(timeSlice.Text==""){
                        timeSliceText.ForeColor=Color.Red;
                    }
                    else{
                        int quant;
                        Int32.TryParse(timeSlice.Text,out quant);
                        new RR(getData(), quant);
                    }
                    
                    break;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                priority.Show();
                priorityText.Show();
                
            }
            else
            {
                priority.Hide();
                priorityText.Hide();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
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

        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void processName_TextChanged(object sender, EventArgs e)
        {

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
            }
            else
            {
                Int32.TryParse(priority.Text, out temp3);
                newProcess = new Process(name, temp1, temp3);
            }
            processListval.Add(newProcess);
            for(int i=0;i<processListval.Count;i++){
                Console.WriteLine(processListval[i].getName()+"");
            }

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

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton4.Checked)
            {
                timeSlice.Hide();
                timeSliceText.Hide();
            }
            else
            {
                timeSlice.Show();
                timeSliceText.Show();
            }
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
            Console.WriteLine(position.X+" "+position.Y+" "+in_position.X+" "+in_position.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (is_down)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X-position.X , p.Y-position.Y );
                //Location.X = e.Location.X - position.X;
                //Location.Y = e.Location.Y - position.Y;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            is_down = false;
        }
    }
}
