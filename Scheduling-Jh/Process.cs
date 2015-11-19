using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduling_Jh
{
    public class Process
    {
        private bool isEnd;
        private String name;
        private int arrival_time;
        private int burst_time;
        private double awt;
        private double art;
        private int priority;
        public Process(String name, int arrival_time, int burst_time)
        {
            isEnd = false;
            art = 0; awt = 0;
            this.name = name;
            this.arrival_time = arrival_time;
            this.burst_time = burst_time;
        }
        public Process(String name, int arrival_time, int burst_time, int priority)
        {
            isEnd = false;
            art = 0; awt = 0;
            this.name = name;
            this.arrival_time = arrival_time;
            this.burst_time = burst_time;
            this.priority = priority;
        }
        public String getName() { return name; }
        public int getArrivalTime() { return arrival_time; }
        public int getBurstTime() { return burst_time; }
        public int getPriority() { return priority; }
        public void setBurstTime(int time) { burst_time = time; }
    }
}
 