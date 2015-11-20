﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduling_Jh
{
    class FCFS :Scheduler
    {
        
        public FCFS(List<Process> list)
            : base(list)
        {
            
        }
        public int fcfs_compare(Process a, Process b){
            if (a.getArrivalTime() > b.getArrivalTime())
                return 1;
            else if (a.getArrivalTime() == b.getArrivalTime())
                return 0;
            else
                return -1;
        }
        public void fcfs_print()
        {   
            for (int i = 0; i < inputData.Count; i++)
            {
                Console.WriteLine(inputData[i].getArrivalTime());
            }
        }
        public void run(){
            inputData.Sort(fcfs_compare);
            currentTime += inputData[0].getArrivalTime();
            for (int i = 0; i < inputData.Count; i++)
            {
                addStamp(new Stamp(inputData[i].getName(), currentTime, (inputData[i].getBurstTime() + currentTime)));
                currentTime += inputData[i].getBurstTime();
            }
        }
        
    }
}
