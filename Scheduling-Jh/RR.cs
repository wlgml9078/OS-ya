using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduling_Jh
{
    class RR :Scheduler
    {
        Queue<Process> Ready;   //레디큐
        int quant;
        public RR(List<Process> list, int q)
            :base(list)
        {            
            Ready = new Queue<Process>();
            quant = q;
            currentTime = 0;

            for (int i = 0; i < inputData.Count; i++)
            {
                Ready.Enqueue(list[i]);
            }
        }


        public void rr_alg()
        {
            while(Ready.Count>0)
            {
                int start = 0, end = 0;

                //Console.WriteLine("Initial:" +Ready.Count+","+ (Ready.Peek().getArrivalTime() >= currentTime));

                if (Ready.Peek().getArrivalTime() <= currentTime)  //현재 시간이 도착 시간보다 큰 경우
                {
                    Process p = Ready.Dequeue();    //먼저 큐에서 삭제

                    //Console.WriteLine("P" + Ready.Peek().getName() + "," + Ready.Peek().getBurstTime() + " start RR");
                    //Console.WriteLine("boolean:"+(p.getBurstTime() > quant));

                    if (p.getBurstTime() > quant)   //BURST 시간이 단위 시간보다 큰 경우
                    {
                        start = currentTime;    //시작 시간 계산
                        p.setBurstTime(p.getBurstTime() - quant);   //남은 BURST 시간 QUANT만큼 줄임
                        currentTime += quant;   //현재 시간을 QUANT만큼 늘림
                        end = currentTime;  //끝 시간 계산

                        Ready.Enqueue(p);
                        Stamp s = new Stamp(p.getName(), start, end);
                        addStamp(s); //stamp 추가

                        //Console.WriteLine("1:" + start + " " + end, currentTime);
                        s.print();
                        //Console.WriteLine("Ready:P" + Ready.Peek().getName() + "," + Ready.Peek().getBurstTime());
                    }
                    else
                    {
                        start = currentTime;    //시작 시간 계산
                        currentTime += p.getBurstTime();    //BURST 시간만큼 현재 시간 늘림
                        end = currentTime;  //끝 시간 계산

                        Stamp s = new Stamp(p.getName(), start, end);
                        addStamp(s); //stamp 추가
                        s.print();
                        //Console.WriteLine("2:" + start + " " + end, currentTime);
                        //Console.WriteLine("Ready:" + Ready.Peek().getName() + "," + Ready.Peek().getBurstTime());
                    }
                }
                else
                {
                    //Console.WriteLine("설마 여기?");
                    currentTime++;
                }
                //Console.WriteLine("Ready2:P" + Ready.Peek().getName() + "," + Ready.Peek().getBurstTime());
                //Console.WriteLine("Initial:" +Ready.Count);
            }
            //Console.WriteLine("End RR");
        }
    }
}
