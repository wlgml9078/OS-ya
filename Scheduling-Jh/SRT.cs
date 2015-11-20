using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduling_Jh
{
    class SRT :Scheduler    //선점!
    {
        Queue<Process> Ready;   //레디큐

        public SRT(List<Process> list)
            :base(list)
        {
            Ready = new Queue<Process>();
            currentTime = 0;

            for (int i = 0; i < inputData.Count; i++)   //큐에 리스트 복사
            {
                Process p = new Process(list[i].getName(), list[i].getArrivalTime(), list[i].getBurstTime());
                Ready.Enqueue(p);
            }
        }

        public void srt_alg()
        {
            while (Ready.Count > 0)
            {
                int start = 0, end = 0;

                
            }
        }
    }
}
