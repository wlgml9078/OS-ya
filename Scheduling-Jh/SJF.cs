using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduling_Jh
{
    class SJF :Scheduler
    {
        List<Process> Ready;   //레디큐
        List<Process>[] temp;
        public SJF(List<Process> list)
            :base(list)
        {
            
            Ready = new List<Process>();
            Comparer c = new Comparer(1);
            currentTime = 0;

            //for (int i = 0; i < inputData.Count; i++)
            //{
            //    Process p = new Process(list[i].getName(), list[i].getArrivalTime(), list[i].getBurstTime());
            //    Ready.Add(p);
            //}
            Ready.Sort(c);
        }
        public void sjf_run()
        {
            temp = new List<Process>[10];
            for (int i = 0; i < 10; i++)
            {
                temp[i] = new List<Process>();
            }
            //들어온순-우선순위으로 정렬(기수정렬을 응용)
            inputData.Sort(pro_compare);//들어온 순으로 정렬
            for (int i = 0; i < inputData.Count; i++)
            {
                temp[inputData[i].getArrivalTime()].Add(inputData[i]);//도착시간의 범위가 0-9 이므로 이렇게 했습니다
            }
            for (int i = 0; i < 10; i++)
            {
                temp[i].Sort(bur_compare);
            }
            inputData = new List<Process>();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < temp[i].Count; j++)
                {
                    inputData.Insert(0, temp[i][j]);//저게 큐가 아니니까 이렇게 처리해야 순서대로 들어갑니다
                }
            }


            List<int> blacklist=new List<int>();
            inputData.Sort(pro_compare);

            for (int i = 0; i < inputData.Count; i++) {
                Console.WriteLine(inputData[i].getName());
            }
                //airgap
            blacklist.Add(0);
            Ready.Insert(0, inputData[0]);
            for (int i = 0; i < inputData.Count; i++)
            {   
                Ready.Sort(bur_compare);
                for (int j = 0; j < Ready.Count; j++) 
                {
                    Console.WriteLine("Ready["+j+"]"+Ready[j].getName());
                }
                Console.WriteLine(" ");
                addStamp(new Stamp(Ready[0].getName(), currentTime, (currentTime += Ready[0].getBurstTime())));
                
                for (int j = 0; j < inputData.Count; j++) {
                    if (inputData[j].getName().CompareTo(Ready[0].getName()) == 0)
                        inputData[j].setEndTime(currentTime);
                }
                Ready.RemoveAt(0);
                
                //검색
                for (int j = 0; j < inputData.Count; j++) 
                {
                    if (inputData[j].getArrivalTime() < currentTime)
                    {
                        bool flag = true;
                        for (int l = 0; l < blacklist.Count; l++)
                        {
                            if (j == blacklist[l])
                            {
                                flag = false;
                            }
                        }
                        if (flag) { 
                            Ready.Add(inputData[j]);
                            blacklist.Insert(0,j);
                        }
                    }
                }
                
            }
        }




        public void sjf_alg()
        {
            int start = 0, end = 0;

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
                        currentTime++;
                    }
                }
            }
        }
        public int bur_compare(Process a, Process b)    //정렬 Priority 기준으로 할라고 만듬
        {
            if (a.getBurstTime() > b.getBurstTime())
                return 1;
            else if (a.getBurstTime() == b.getBurstTime())
                return 0;
            else
                return -1;
        }
    }
}
