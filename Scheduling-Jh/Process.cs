using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduling_Jh
{
    public class Process
    {
        private String name;
        private int arrival_time;
        private int burst_time;
        private int priority;
        public Process(String name, int arrival_time, int burst_time)
        {
            this.name = name;
            this.arrival_time = arrival_time;
            this.burst_time = burst_time;
        }
        public Process(String name, int arrival_time, int burst_time, int priority)
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
}
 