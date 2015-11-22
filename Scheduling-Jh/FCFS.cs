using System;
using System.Collections.Generic;
using System.Linq;

using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

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
        public void fcfs_run()
        {
            inputData.Sort(fcfs_compare);
            //airgap
            for (int i = 0; i < inputData.Count; i++)
            {
                if (currentTime > inputData[i].getArrivalTime()) {
                    addStamp(new Stamp(inputData[i].getName(), currentTime, (currentTime+=inputData[i].getBurstTime())));                    
                }
                else
                {
                    currentTime = inputData[i].getArrivalTime();
                    addStamp(new Stamp(inputData[i].getName(), currentTime, (currentTime += inputData[i].getBurstTime())));                    
                }
                inputData[i].setEndTime(currentTime);                                 
            }
            
        }
        
    }
}
