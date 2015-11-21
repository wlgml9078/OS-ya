using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduling_Jh
{
    class SRT :Scheduler    //선점방식 사용
    {
        Queue<Process> Ready;   //레디큐
        List<Process> List;

        public SRT(List<Process> list)
            :base(list)
        {
            Ready = new Queue<Process>();
            List = new List<Process>();
            currentTime = 0;

            for (int i = 0; i < inputData.Count; i++)   //큐에 리스트 복사
            {
                Process p = new Process(list[i].getName(), list[i].getArrivalTime(), list[i].getBurstTime());
                Ready.Enqueue(p);
            }
        }

        public void srt_alg()   //srt 어렵ㅜㅜㅎ 내일함
        {
            //while (Ready.Count > 0)
            //{
            //    int start = 0, remained = 0, end = 0;

            //    if (Ready.Peek().getArrivalTime() <= currentTime)  //현재 시간이 도착 시간보다 큰 경우
            //    {
            //        Process p = Ready.Dequeue();
                    
            //        if(Ready.Peek().getArrivalTime() > (p.getBurstTime() + currentTime))
            //        {
            //            start = currentTime;
            //            currentTime = Ready.Peek().getArrivalTime() - currentTime;
            //            remained = p.getBurstTime() - currentTime;
            //            p.setBurstTime(remained);
            //            end = currentTime;

            //            Ready.Enqueue(p);

            //            Stamp s = new Stamp(p.getName(), start, end, remained);
            //            addStamp(s); //stamp 추가
            //        }
            //        else
            //        {
            //            start = currentTime;
            //            currentTime += p.getBurstTime();
            //            end = currentTime;

            //            for (int i = 0; i < inputData.Count;)
            //            {
            //                if (inputData[i].getName().Equals(p.getName()))
            //                    inputData[i].setEndTime(currentTime);
            //                break;
            //            }

            //            Stamp s = new Stamp(p.getName(), start, end, remained);
            //            addStamp(s); //stamp 추가
            //        }
            //    }
            //    else //현재 실행가능한 프로세스가 없는 경우
            //    {
            //        currentTime++;
            //    }
            //}
        }
    }
}
