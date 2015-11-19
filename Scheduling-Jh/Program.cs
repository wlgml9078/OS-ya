using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Scheduling_Jh
{
    public class Process
    {
        private String name;
        private int arrival_time;
        private int burst_time;
        private int priority;
        Process(String name,int arrival_time,int burst_time )
        {
            this.name = name;
            this.arrival_time = arrival_time;
            this.burst_time = burst_time;
        }
        Process(String name, int arrival_time, int burst_time,int priority)
        {
            this.name = name;
            this.arrival_time = arrival_time;
            this.burst_time = burst_time;
            this.priority = priority;
        }
        String getName() { return name; }
        int getArrivalTime() { return arrival_time; }
        int getBurstTime() { return burst_time; }
        int getPriority() { return priority; }
    }
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new main());
        }
    }
}
