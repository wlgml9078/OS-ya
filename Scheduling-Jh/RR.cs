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
        public RR(List<Process> list, int n)
            :base(list)
        {
            quant = n;
            IEnumerator<Process> e = inputData.GetEnumerator();
            Ready=new Queue<Process>();
            while(!e.MoveNext())
            {
                Ready.Enqueue(e.Current);
            }
        }

        public void rr_alg()
        {
            while(Ready.Count!=0)
            {
                int start, end;

                if (Ready.Peek().getArrivalTime() >= currentTime)  //현재 시간이 도착 시간보다 큰 경우
                {
                    Process p = Ready.Dequeue();    //큐에서 삭제
                    if (p.getBurstTime() > quant)   //BURST 시간이 단위 시간보다 큰 경우
                    {
                        start = currentTime;    //시작 시간 계산
                        p.setBurstTime(p.getBurstTime() - quant);   //남은 BURST 시간 QUANT만큼 줄임
                        currentTime += quant;   //현재 시간을 QUANT만큼 늘림
                        end = currentTime;  //끝 시간 계산

                        Ready.Enqueue(p);
                        addStamp(new Stamp(p.getName(), start, end)); //stamp 추가
                    }
                    else
                    {
                        start = currentTime;    //시작 시간 계산
                        currentTime += p.getBurstTime();    //BURST 시간만큼 현재 시간 늘림
                        end = currentTime;  //끝 시간 계산

                        addStamp(new Stamp(p.getName(), start, end)); //stamp 추가
                    }
                }
                else
                {
                    currentTime++;
                }
            }
        }
    }
}
