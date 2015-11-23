using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduling_Jh
{
    class HRN : Scheduler
    {
        Queue<Process_HRN> Ready;
        List<Process_HRN> Arrived;

        public HRN(List<Process> list)
            : base(list)
        {
            currentTime = 0;
            Ready = new Queue<Process_HRN>();
            Arrived = new List<Process_HRN>();
            for (int i = 0; i < inputData.Count; i++)
            {
                Process_HRN p = new Process_HRN(inputData[i].getName(), inputData[i].getArrivalTime(), inputData[i].getBurstTime());
                Ready.Enqueue(p);
            }
        }

        public void hrn_alg()
        {
            int start = 0, end = 0;
            do
            {
                Process_HRN process;
                while (Ready.Count > 0 && Ready.Peek().getArrivalTime() <= currentTime)
                {
                    Arrived.Add(Ready.Dequeue());
                    Console.WriteLine("check!:"+Ready.Count + "," + Arrived.Count);
                }

                for (int i = 0; i < Arrived.Count; i++)
                {
                    if (Arrived[i].getArrivalTime() <= currentTime)
                    {
                        for (int j = 0; j < Arrived.Count; j++)
                        {
                            double p = (currentTime - Arrived[j].getArrivalTime() + Arrived[j].getBurstTime()) / (double)Arrived[j].getBurstTime();
                            Arrived[j].setPriority(p);
                        }
                        Arrived.Sort(new Comparer_HRN());

                        start = currentTime;
                        process = Arrived.First();
                        currentTime += process.getBurstTime();
                        end = currentTime;

                        Console.WriteLine(currentTime);

                        Stamp s = new Stamp(process.getName(), start, end);
                        addStamp(s);

                        Arrived.RemoveAt(0);
                        break;
                    }
                }
                Console.WriteLine(Ready.Count+","+Arrived.Count);
            } while (Ready.Count > 0 || Arrived.Count > 0);
        }
    }
}