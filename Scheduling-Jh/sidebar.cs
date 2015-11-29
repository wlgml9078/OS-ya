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
    public partial class sidebar : Form
    {
        List<Process> process_list;
        public sidebar(List<Process> list)
        {            
            InitializeComponent();
            process_list = list;
            for (int i = 0; i < process_list.Count; i++) 
            {
                
                
                if (list[i].getPriority() == -1) {
                    String[] mylist = { list[i].getName(), list[i].getArrivalTime() + "", list[i].getBurstTime() + "" ,""};
                    var listViewItem = new ListViewItem(mylist);
                    listView1.Items.Add(listViewItem);
                }
                else
                {
                    String[] mylist = { list[i].getName(), list[i].getArrivalTime() + "", list[i].getBurstTime() + "", list[i].getPriority() + "" };
                    var listViewItem = new ListViewItem(mylist);
                    listView1.Items.Add(listViewItem);
                }
                
            }
            
        }
        
    }
}
