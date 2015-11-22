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

            for (int i = 0; i < inputData.Count; i++)   //큐에 리스트 복사
            {
                Process p = new Process(list[i].getName(),list[i].getArrivalTime(),list[i].getBurstTime());
                Ready.Enqueue(p);
            }
        }


        public void rr_alg()
        {
            while(Ready.Count>0)
            {
                int start = 0, remained = 0, end = 0;

                if (Ready.Peek().getArrivalTime() <= currentTime)  //현재 시간이 도착 시간보다 큰 경우
                {
                    Process p = Ready.Dequeue();    //먼저 큐에서 삭제

                    if (p.getBurstTime() > quant)   //BURST 시간이 단위 시간보다 큰 경우
                    {
                        start = currentTime;    //시작 시간 계산

                        remained = p.getBurstTime() - quant;
                        p.setBurstTime(remained);   //남은 BURST 시간 QUANT만큼 줄임
                        currentTime += quant;   //현재 시간을 QUANT만큼 늘림

                        end = currentTime;  //끝 시간 계산

                        Ready.Enqueue(p);
                        Stamp s = new Stamp(p.getName(), start, end, remained);
                        addStamp(s); //stamp 추가
                    }
                    else
                    {
                        start = currentTime;    //시작 시간 계산
                        currentTime += p.getBurstTime();    //BURST 시간만큼 현재 시간 늘림
                        end = currentTime;  //끝 시간 계산

                        for (int i = 0; i < inputData.Count; i++)
                        {
                            if (inputData[i].getName().Equals(p.getName()))
                            {
                                inputData[i].setEndTime(currentTime);
                                break;
                            }
                        }

                        Stamp s = new Stamp(p.getName(), start, end); 
                        addStamp(s); //stamp 추가
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
