using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduling_Jh
{
    class SRT :Scheduler    //선점방식 사용
    {
        int max_num;
        List<Process>[] temp;
        List<Process> Ready;
        List<Process> Copy;
        public SRT(List<Process> list)
            :base(list)
        {
            currentTime = 0;
            max_num = 0;
            Ready = new List<Process>();
            Copy = list;
        }
        private int isNowInStamp(Process p, List<Stamp> list)//currentTime이 스탬프에 찍혀있는 범위 내의 값인지 확인
        {
            for (int i = 0; i < list.Count; i++) 
            {
                if (p.getArrivalTime() < list[i].getStartTime() && p.getArrivalTime() + p.getBurstTime() > timestamp[i].getStartTime())    //스탬프의 앞쪽이 겹칠 때
                {
                    return 0;
                }
                if (p.getArrivalTime() >= list[i].getStartTime() && p.getArrivalTime() < list[i].getEndTime())   //스탬프랑 겹칠때 (FCFS 쓸 때)
                {
                    return 1;
                }
            }
            return 2;   //아무 경우도 X
        }
        public void srt_run() {
            int max_run = -1;
            for (int i = 0; i < inputData.Count; i++)
            {
                max_run = ((max_run > inputData[i].getBurstTime()) ? max_run : inputData[i].getBurstTime());
            }
            max_run++;
            temp = new List<Process>[max_run];
            for (int i = 0; i < max_run; i++)
            {
                temp[i] = new List<Process>();
            }
            //들어온순-우선순위으로 정렬(기수정렬을 응용)
            inputData.Sort(bur_compare);//들어온 순으로 정렬
            for (int i = 0; i < inputData.Count; i++)
            {
                temp[inputData[i].getBurstTime()].Add(inputData[i]);//도착시간의 범위가 0-9 이므로 이렇게 했습니다
            }
            for (int i = 0; i < max_run; i++)
            {
                temp[i].Sort(pro_compare);
            }
            inputData = new List<Process>();
            for (int i = 0; i < max_run; i++)
            {
                for (int j = 0; j < temp[i].Count; j++)
                {
                    inputData.Add(temp[i][j]);//저게 큐가 아니니까 이렇게 처리해야 순서대로 들어갑니다
                }
            }
            for (int i = 0; i < inputData.Count; i++)
            {
                Console.WriteLine("SRTNAME:" + inputData[i].getName());
            }
            for(int i=0;i<Copy.Count;i++){
                Ready.Add(Copy[i]);
                Ready.Sort(bur_compare);
                currentTime=Ready[0].getArrivalTime();

               
                switch (isNowInStamp(Ready[0], timestamp))
                {
                    case 0:
                        Console.WriteLine("case 0");
                        int now = Ready[0].getArrivalTime();
                        int cuttingline = 1000;
                        for (int j = 0; j < timestamp.Count; j++)
                        {
                            if (timestamp[j].getStartTime() > now)
                            {
                                if (timestamp[j].getStartTime() < cuttingline)
                                {
                                    cuttingline = timestamp[j].getStartTime();
                                }
                            }
                        }
                        //
                        if (cuttingline == Ready[0].getArrivalTime())
                        {
                            int index = 0;
                            for (int j = 0; j < inputData.Count; j++)
                            {
                                if (Ready[0].getName().CompareTo(inputData[i].getName()) == 0)
                                {
                                    index = j;
                                    break;
                                }
                            }
                            inputData[index].setEndTime(cuttingline);
                        }
                        else
                        {
                            addStamp(new Stamp(Ready[0].getName(), Ready[0].getArrivalTime(), cuttingline));
                            Console.WriteLine("stamp" + timestamp[timestamp.Count - 1].getStartTime() + "," + timestamp[timestamp.Count - 1].getEndTime());
                            Copy.Insert(i+1,new Process(Ready[0].getName(), cuttingline, Ready[0].getBurstTime() - (cuttingline - Ready[0].getArrivalTime())));
                        }
                        break;
                    case 1:
                        Console.WriteLine("case 1");
                        int endpoint = 0;                        
                        for (int j = 0; j < timestamp.Count; j++)
                        {
                            if (Ready[0].getArrivalTime() >= timestamp[j].getStartTime() && Ready[0].getArrivalTime() < timestamp[j].getEndTime())
                            {
                                endpoint = timestamp[j].getEndTime();
                                Console.WriteLine(timestamp[j].getName());
                                break;
                            }
                        }
                        //Console.WriteLine("Ready[0]:" + Ready[0].getName() + ":" + Ready[0].getArrivalTime() + "," + Ready[0].getBurstTime());
                        Copy.Add(new Process(Ready[0].getName(), endpoint, Ready[0].getBurstTime()));
                        Console.WriteLine("stamp" + timestamp[timestamp.Count - 1].getStartTime() + "," + timestamp[timestamp.Count - 1].getEndTime());
                        break;
                    case 2:
                        Console.WriteLine("case 2");

                        addStamp(new Stamp(Ready[0].getName(), currentTime, currentTime += Ready[0].getBurstTime()));
                        Console.WriteLine("stamp" + timestamp[timestamp.Count - 1].getStartTime() + "," + timestamp[timestamp.Count - 1].getEndTime());
                        inputData[i].setEndTime(currentTime);
                        break;
                }                

                //Console.WriteLine("Ready[0]" + Ready[0].getName());
                Ready.RemoveAt(0);

            }
            
            
 
        }
        //public void srt_alg()
        //{
            
        //    do
        //    {
        //        Process p = Ready.First();
        //        StampProcess(p);
        //    } while (Ready.Count > 0);
        //}
        //private void StampProcess(Process p)
        //{
        //    int type = isNowInStamp(p, timestamp);
        //    Stamp s;
        //    int startpoint = 0, endpoint = 0;
        //    Process tmp, next;
        //    switch (type)
        //    {
        //        case 0:
        //            Console.WriteLine("<type 0>");
        //            for (int i = 0; i < timestamp.Count; i++)
        //            {
        //                if (p.getArrivalTime() < timestamp[i].getStartTime() && p.getArrivalTime() + p.getBurstTime() > timestamp[i].getStartTime())
        //                {
        //                    startpoint = timestamp[i].getStartTime();
        //                    endpoint = timestamp[i].getEndTime();
        //                    break;
        //                }
        //            }
        //            int n_burst = p.getBurstTime() - (startpoint - p.getArrivalTime());

        //            tmp = new Process(p.getName(), endpoint, n_burst);
        //            Ready.Add(tmp);
        //            Sorting();

        //            s = new Stamp(p.getName(), p.getArrivalTime(), startpoint);
        //            addStamp(s);
        //            Console.WriteLine("<type 0 end>");
        //            break;
        //        case 1:
        //            Console.WriteLine("<type 1>");
        //            for (int i = 0; i < timestamp.Count; i++)
        //            {
        //                if (p.getArrivalTime() >= timestamp[i].getStartTime() && p.getArrivalTime() < timestamp[i].getEndTime())
        //                {
        //                    startpoint = timestamp[i].getStartTime();
        //                    endpoint = timestamp[i].getEndTime();
        //                    break;
        //                }
        //            }
        //            tmp = new Process(p.getName(), endpoint, p.getBurstTime());
        //            Ready.Add(tmp);
        //            Sorting();
        //            Console.WriteLine("<type 1 end>");
        //            break;
        //        case 2:
        //            Console.WriteLine("<type 2>");
        //            int end = p.getArrivalTime() + p.getBurstTime();
        //            s = new Stamp(p.getName(), p.getArrivalTime(), end);
        //            addStamp(s);
        //            Console.WriteLine(s.getName() + ":" + s.getStartTime() + "~" + s.getEndTime());
        //            for (int i = 0; i < inputData.Count; i++)
        //            {
        //                if (inputData[i].getName().Equals(s.getName()))
        //                {
        //                    inputData[i].setEndTime(end);
        //                }
        //            }
        //            Console.WriteLine("<type 2 end>");
        //            break;
        //    }
        //}
        public int bur_compare(Process a, Process b)    //정렬 BurstTime 기준으로 할라고 만듬
        {
            if (a.getBurstTime() > b.getBurstTime())
                return 1;
            else if (a.getArrivalTime() == b.getArrivalTime())
                return 0;
            else
                return -1;
        }
    }
}

