using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduling_Jh
{
    class Pri_Comparer :IComparer<Process>
    {
        public int Compare(Process x, Process y)
        {
            return x.getPriority().CompareTo(y.getPriority());
        }
    }


    class Priority :Scheduler
    {
        List<Process> Ready;
        public Priority(List<Process> list)
            :base(list)
        {
            Ready = new List<Process>();

            for(int i=0; i<list.Count; i++)
            {
                Ready.Add(new Process(list[i].getName(),list[i].getArrivalTime(),list[i].getBurstTime(),list[i].getPriority()));    //큐 삽입
            }
            Ready.Sort(new Pri_Comparer());
        }
        public void pri_alg(bool type)  //이거 알고리즘 틀림..^^
        {
            int start = 0, end = 0;
            if(type)    //비선점 Priority
            {
                while (Ready.Count > 0) //레디 큐에 아무것도 남지 않을 때까지 반복
                {
                    for (int i = 0; i < Ready.Count; i++)
                    {
                        Process p = Ready[i];
                        if (p.getArrivalTime() <= currentTime)   //현재 시간과 도착 시간 비교
                        {
                            start = currentTime;    //시작 시간
                            currentTime += p.getBurstTime(); //BURST 시간만큼 현재 시간 늘림
                            end = currentTime;  //끝 시간

                            for (int j = 0; j < inputData.Count; j++)
                            {
                                if (inputData[j].getName().Equals(p.getName()))
                                {
                                    inputData[j].setEndTime(end);   //endtime 설정
                                    break;
                                }
                            }

                            Stamp s = new Stamp(p.getName(), start, end);
                            addStamp(s); //stamp 추가
                            Ready.RemoveAt(i);  //레디큐에서 삭제

                            break;
                        }
                        else        //현재 시간에 실행할 수 있는 프로세스가 없는 경우
                        {
                            if (i >= Ready.Count) currentTime++;
                        }
                    }
                }
            }
            else
            {

            }
        }
    }
}
