using System;
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
        public void run(){
            currentTime += inputData[0].getArrivalTime();
            for (int i = 0; i < inputData.Count; i++)
            {
                addStamp(new Stamp(inputData[i].getName(), currentTime, (inputData[i].getBurstTime() + currentTime)));
                currentTime += inputData[i].getBurstTime();
            }
        }
        
    }
}
