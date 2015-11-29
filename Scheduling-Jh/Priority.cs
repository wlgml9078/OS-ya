using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduling_Jh
{
    class Priority :Scheduler
    {
        List<Process>[] temp;
        List<Process> Ready;
        List<Process> Copy=new List<Process>();
        public Priority(List<Process> list)
            :base(list)
        {
            Copy = list;
            currentTime = 0;
            Ready = new List<Process>();
        }
        private int isNowInStamp(Process p, List<Stamp> list)//currentTime이 스탬프에 찍혀있는 범위 내의 값인지 확인
        {
            for (int i = 0; i < list.Count; i++) 
            {
                if (p.getArrivalTime() < list[i].getStartTime() && p.getArrivalTime() + p.getBurstTime() > timestamp[i].getStartTime())    //스탬프의 앞쪽이 겹칠 때
                    return 0;
                if (p.getArrivalTime() >= list[i].getStartTime() && p.getArrivalTime() < list[i].getEndTime())   //스탬프랑 겹칠때 (FCFS 쓸 때)
                    return 1;
            }
            return 2;   //아무 경우도 X
        } 
        public void pri_run(bool preemptive) //그럼 내가 새로 짬.. ㅎㅎ
        {
            if (preemptive)//선점
            {
                //우선순위- 들어온순으로 정렬
                temp = new List<Process>[20];
                for (int i = 0; i < 20; i++)
                {
                    temp[i] = new List<Process>();
                }
                //들어온순-우선순위으로 정렬(기수정렬을 응용)
                inputData.Sort(pri_compare);//우선순위
                for (int i = 0; i < inputData.Count; i++)
                {
                    temp[inputData[i].getPriority()].Add(inputData[i]);//우선순위의 범위가 0-9 이므로 이렇게 했습니다
                }
                
                for (int i = 0; i < 20; i++)
                {
                    temp[i].Sort(pro_compare);
                }
                inputData = new List<Process>();
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < temp[i].Count; j++)
                    {
                        inputData.Insert(0, temp[i][j]);//저게 큐가 아니니까 이렇게 처리해야 순서대로 들어갑니다
                        Ready.Add(temp[i][j]);
                    }
                }

                do
                {
                    Process p = Ready.First();
                    StampProcess(p);
                    Ready.RemoveAt(0);
                } while (Ready.Count > 0);
            }
            else   //비선점
            {
                temp=new List<Process>[20];
                for (int i = 0; i < 20; i++) {
                    temp[i] = new List<Process>();
                }
                //들어온순-우선순위으로 정렬(기수정렬을 응용)
                Copy.Sort(pro_compare);//들어온 순으로 정렬
                
                for (int i = 0; i < inputData.Count; i++)
                {
                    temp[Copy[i].getArrivalTime()].Add(Copy[i]);//도착시간의 범위가 0-9 이므로 이렇게 했습니다
                }
                for (int i = 0; i < 20; i++) 
                {
                    temp[i].Sort(pri_compare);
                }
                Copy=new List<Process>();
                for (int i = 0; i < 20; i++) {
                    for (int j = 0; j < temp[i].Count; j++) {
                        Copy.Add(temp[i][j]);//저게 큐가 아니니까 이렇게 처리해야 순서대로 들어갑니다
                    }
                }
                //정렬은 끝났고 아래부분에서는 처리해줍니다                
                for (int i = 0; i < inputData.Count; i++)//즉 시간순으로 처리됩니다
                {
                    Ready.Add(Copy[0]);//리스트에 들어온 순서대로 데이터를 넣었습니다 이후 모든 처리는 큐를 기준으로 돌아갑니다
                    Copy.RemoveAt(0);
                    Copy.Sort(pri_compare);//큐가 아닌 리스트이므로 리스트를 큐처럼 만들기 위해 정렬을 합니다.
                    if (currentTime > Ready[0].getArrivalTime())//현재 시간이 실행할 놈 도착시간보다 빠르면(겹치면)
                    {
                        addStamp(new Stamp(Ready[0].getName(), currentTime, (currentTime += Ready[0].getBurstTime()))); //스탬프 쾅쾅
                    }
                    else
                    {
                        currentTime = Ready[0].getArrivalTime();
                        addStamp(new Stamp(Ready[0].getName(), currentTime, (currentTime += Ready[0].getBurstTime()))); //스탬프 쾅쾅
                    }
                    //this is the way how to get the tombstone point
                    int target = 0;
                    for (int j = 0; j < inputData.Count; j++) {
                        if (Ready[0].getName().CompareTo(inputData[j].getName()) == 0)
                        {
                            target = j;
                        }                        
                    }
                    inputData[target].setEndTime(currentTime);//프로세스의 묘비명을 적어줍니다
                    
                    Ready.RemoveAt(0);//실행끝난 프로세스는 죽입니다
                }
            }
        }

        private void StampProcess(Process p)
        {
            int type = isNowInStamp(p,timestamp);
            Stamp s;
            int startpoint=0, endpoint=0;
            Process next;
            switch(type)
            {
                case 0:
                    Console.WriteLine("<type 0>");
                    for(int i=0; i<timestamp.Count; i++)
                    {
                        if(p.getArrivalTime() < timestamp[i].getStartTime() && p.getArrivalTime()+p.getBurstTime()>timestamp[i].getStartTime())
                        {
                            startpoint = timestamp[i].getStartTime();
                            endpoint = timestamp[i].getEndTime();
                            break;
                        }
                    }
                    int n_burst = p.getBurstTime() - (startpoint - p.getArrivalTime());

                    Console.WriteLine("n_b:" + n_burst);

                    next = new Process(p.getName(), endpoint, n_burst);
                    s = new Stamp(p.getName(), p.getArrivalTime(), startpoint);

                    addStamp(s);
                    StampProcess(next); //순환 호출
                    Console.WriteLine("<type 0 end>");
                    break;
                case 1:
                    Console.WriteLine("<type 1>");
                    for (int i = 0; i < timestamp.Count; i++)
                    {
                        if (p.getArrivalTime() >= timestamp[i].getStartTime() && p.getArrivalTime() < timestamp[i].getEndTime())
                        {
                            startpoint = timestamp[i].getStartTime();
                            endpoint = timestamp[i].getEndTime();
                            break;
                        }
                    }
                    next = new Process(p.getName(), endpoint, p.getBurstTime());
                    StampProcess(next);
                    Console.WriteLine(endpoint + "," + next.getName() + ":" + next.getArrivalTime() + "," + next.getBurstTime());
                    Console.WriteLine("<type 1 end>");
                    break;
                case 2:
                    Console.WriteLine("<type 2>");
                    int end = p.getArrivalTime() + p.getBurstTime();
                    s = new Stamp(p.getName(), p.getArrivalTime(), end);
                    addStamp(s);
                    for (int i = 0; i < inputData.Count; i++ )
                    {
                        if (inputData[i].getName().Equals(s.getName()))
                        {
                            inputData[i].setEndTime(end);
                            Console.WriteLine(inputData[i].getName() +":"+ s.getStartTime() + "," + s.getEndTime());
                        }
                    }
                    Console.WriteLine("<type 2 end>");
                    break;
            }
        }

        public int pri_compare(Process a, Process b)    //정렬 Priority 기준으로 할라고 만듬
        {
            if (a.getPriority() > b.getPriority())
                return 1;
            else if (a.getArrivalTime() == b.getArrivalTime())
                return 0;
            else
                return -1;
        }
    }
}
