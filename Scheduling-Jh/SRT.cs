﻿using System;
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
            
            bool is_start_dup=false;
            bool is_end_dup=false;
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("searching process:str:" + list[i].getStartTime() + " end" + list[i].getEndTime());
                if ((list[i].getStartTime() <= p.getArrivalTime()) && (list[i].getEndTime() > p.getArrivalTime()))
                {                    
                    is_start_dup = true;
                    break;
                }
                //if(p.getArrivalTime()>=list[i].getStartTime()&&p.getArrivalTime()<list[i].getEndTime())
                //    is_start_dup=true;

                if (list[i].getStartTime() <= p.getArrivalTime() + p.getBurstTime() && list[i].getEndTime() >= p.getArrivalTime() + p.getBurstTime())
                {
                    is_end_dup = true;
                }
                //if (p.getArrivalTime() + p.getBurstTime() >= list[i].getStartTime() && p.getArrivalTime() + p.getBurstTime() <= list[i].getEndTime())
                //    is_end_dup=true;
                if(p.getArrivalTime()<list[i].getStartTime()&&p.getArrivalTime()+p.getBurstTime()>list[i].getEndTime())
                    return 0;
                if (p.getArrivalTime() > list[i].getStartTime() && p.getArrivalTime() + p.getBurstTime() < list[i].getEndTime())
                    return 1;
            }
            if(is_start_dup){
                return 1;
            }
            else if(is_end_dup){
                return 0;
            }
            else{
                return 2;
            }
            
            //for (int i = 0; i < list.Count; i++) 
            //{
                
            //    if (p.getArrivalTime() >= list[i].getStartTime())   //스탬프랑 겹칠때 (FCFS 쓸 때)
            //    {
            //        if (p.getArrivalTime() < list[i].getEndTime())
            //        {
            //            return 1;
            //        }
            //    }
            //    if (p.getArrivalTime() < list[i].getStartTime())    //스탬프의 앞쪽이 겹칠 때
            //    {
            //        if (p.getArrivalTime() + p.getBurstTime() > timestamp[i].getStartTime())
            //        {
            //            return 0;
            //        }

            //    }            
            //}
            //return 2;   //아무 경우도 X
        }
        public void srt_run() {
            Copy.Sort(pro_compare);
            for (int i = 0; i < Copy.Count||Ready.Count==0; i++) {
                Console.WriteLine("Current"+ Copy[i].getName()+" arr:"+Copy[i].getArrivalTime()+" bur"+Copy[i].getBurstTime());
                
                Ready.Add(Copy[i]);
                Ready.Sort(bur_compare);
                if (i < Copy.Count - 1)
                {
                    int index = 0;
                    for (int j = 0; j < inputData.Count; j++) 
                    {
                        if(Copy[i].getName().CompareTo(inputData[j].getName())==0)
                        {
                            index = j;
                        }
                    }
                    if ((currentTime+Copy[i].getBurstTime())<= Copy[i + 1].getArrivalTime())
                    {//다음 프로세스의 시작시간과 겹치지 않은 경우
                        Console.WriteLine("case 0");
                        timestamp.Add(new Stamp(Ready[0].getName(), Copy[i].getArrivalTime(), Copy[i].getArrivalTime() + Copy[i].getBurstTime()));
                        Console.WriteLine("stamp " +Copy[i].getName()+" " +Copy[i].getArrivalTime() +" "+ (Copy[i].getArrivalTime() + Copy[i].getBurstTime()));
                        inputData[index].setEndTime(Copy[i].getArrivalTime() + Copy[i].getBurstTime());
                        currentTime += Ready[0].getBurstTime();
                    }
                    else //겹친 경우에는 준비 큐에 삽입 
                    {
                        Console.WriteLine("case 1");
                        timestamp.Add(new Stamp(Ready[0].getName(), Copy[i].getArrivalTime(), Copy[i+1].getArrivalTime()));
                        Console.WriteLine("stamp " +Copy[i].getName()+" "+ Copy[i].getArrivalTime() + " " + Copy[i + 1].getArrivalTime());
                        Copy.Insert(i+1,new Process(Ready[0].getName(), Copy[i + 1].getArrivalTime(),Copy[0].getBurstTime()-(Copy[i+1].getArrivalTime()-Copy[i].getArrivalTime())));
                        Console.WriteLine("insert " +Copy[i].getName()+" "+ Copy[i + 1].getArrivalTime() +" "+ (Copy[0].getBurstTime() - (Copy[i + 1].getArrivalTime() - Copy[i].getArrivalTime())));
                        currentTime += Copy[0].getBurstTime() - (Copy[i + 1].getArrivalTime() - Copy[i].getArrivalTime());
                    }
                    Ready.RemoveAt(0);
                    Console.ReadLine();
                }
            }


            //int max_run = -1;
            //for (int i = 0; i < Copy.Count; i++)
            //{
            //    max_run = ((max_run > Copy[i].getBurstTime()) ? max_run : Copy[i].getBurstTime());
            //}
            //max_run++;
            //temp = new List<Process>[max_run];
            //for (int i = 0; i < max_run; i++)
            //{
            //    temp[i] = new List<Process>();
            //}
            ////들어온순-우선순위으로 정렬(기수정렬을 응용)
            //Copy.Sort(bur_compare);//들어온 순으로 정렬
            //for (int i = 0; i < Copy.Count; i++)
            //{
            //    temp[Copy[i].getBurstTime()].Add(Copy[i]);//도착시간의 범위가 0-9 이므로 이렇게 했습니다
            //}
            //for (int i = 0; i < max_run; i++)
            //{
            //    temp[i].Sort(pro_compare);
            //}
            //Copy = new List<Process>();
            //for (int i = 0; i < max_run; i++)
            //{
            //    for (int j = 0; j < temp[i].Count; j++)
            //    {
            //        Copy.Add(temp[i][j]);//저게 큐가 아니니까 이렇게 처리해야 순서대로 들어갑니다
            //    }
            //}
            //for (int i = 0; i < Copy.Count; i++)
            //{
            //    Console.WriteLine("SRTNAME:" + Copy[i].getName());
            //}
            //for(int i=0;i<Copy.Count;i++){
            //    Ready.Add(Copy[i]);
            //    Ready.Sort(bur_compare);
            //    currentTime=Ready[0].getArrivalTime();

            //    Console.WriteLine("Current: " + Ready[0].getName() + " arr:"+Ready[0].getArrivalTime()+" bur:"+Ready[0].getBurstTime());
            //    switch (isNowInStamp(Ready[0], timestamp))
            //    {
            //        case 0://case 0에서는 프로세스의 후단이 충돌하는 경우. 전단과 후단 모두 충돌하는 경우도 여기에 속함
            //            Console.WriteLine("case 0");
            //            int now = Ready[0].getArrivalTime();//도착시간
            //            int cuttingline = 1000;
            //            int ent=0;//ent는 밀어내는 거리
            //            for (int j = 0; j < timestamp.Count; j++)
            //            {
            //                if (timestamp[j].getStartTime() >= now)
            //                {
            //                    if (timestamp[j].getStartTime() < cuttingline)
            //                    {
            //                        cuttingline = timestamp[j].getStartTime();
            //                        ent=timestamp[j].getEndTime();
            //                    }
            //                }
            //            }
            //            Console.WriteLine(cuttingline);
            //            //fcfs처리
            //            if (cuttingline == now)//이 경우는 도착시간과 잘리는 위치가 동일한 경우.즉 전단-후단이 모두 충돌함
            //            {
            //                Console.WriteLine("setBAck");
            //                Copy.Insert(i + 1, new Process(Ready[0].getName(),ent,Ready[0].getBurstTime()));
            //                Console.WriteLine("insert" + (ent) + " " + Ready[0].getBurstTime());
            //            }
            //            else
            //            {                            
            //                addStamp(new Stamp(Ready[0].getName(), Ready[0].getArrivalTime(), cuttingline));
            //                Console.WriteLine("stamp" + timestamp[timestamp.Count - 1].getStartTime() + "," + timestamp[timestamp.Count - 1].getEndTime());
            //                Copy.Insert(i+1,new Process(Ready[0].getName(), cuttingline, Ready[0].getBurstTime() - (cuttingline - Ready[0].getArrivalTime())));
            //                Console.WriteLine("insert"+cuttingline+" "+(Ready[0].getBurstTime() - (cuttingline - Ready[0].getArrivalTime())));
            //            }
            //            break; 
            //        case 1: //case 1은 프로세스의 전단이 충돌한 경우
            //        //case 1 에서는 스탬프를 찍지 않고, 프로세스를 0번 혹은 2번의 상태로 변환해줍니다(프로세스를 뒤로 미뤄줍니다)
            //            Console.WriteLine("case 1");                        
            //            //가장 이웃한 스탬프를 찾습니다.
            //            timestamp.Sort(stmp_compare);
            //            int neighbout_begin = 0;//이웃한 스탬프의 종료 값을 초기화
            //            int neighbour = 0;//이웃한 스탬프의 시작값 초기화
            //            for (int j = 0; j < timestamp.Count; j++)//스탬프 범위 내에서 검색
            //            {
            //                if (timestamp[j].getStartTime() <= Ready[0].getArrivalTime()) //스탬프의 인덱스번째의 요소의 시작시간이 현재 충돌된 프로세스의 시작시간보다 작으면
            //                {
            //                    if (neighbout_begin <= timestamp[j].getEndTime())//(가칭)이웃한 스탬프의 시작값이 현 인덱스번째의 스탬프의 시작시간보다 작으면
            //                    {
            //                        //여기가 목표 스탬프를 갱신하는 값입니다
            //                        neighbour = timestamp[j].getStartTime();
            //                        neighbout_begin = timestamp[j].getEndTime();
            //                    }
            //                }
            //            }
                        
            //            Console.WriteLine(neighbour);
            //            Process newProcess = new Process(Ready[0].getName(),neighbout_begin,Ready[0].getBurstTime());
            //            Copy.Insert(i+1,newProcess);
            //            Console.WriteLine("insert" + neighbout_begin + " " + Ready[0].getBurstTime());                        
            //            break;
            //        case 2: //case 2는 충돌하지 않은 경우. 프로세스가 끝났음을 확실하게 보장할 수 있습니다.
            //            Console.WriteLine("case 2");
            //            int orig = 0;//오리지날 리스트 내에 존재하는 값을 구하려고 합니다
            //            for (int j = 0; j < inputData.Count; j++)
            //            {
            //                if (Ready[0].getName().CompareTo(inputData[j].getName()) == 0)//프로세스 id가 일치하는 경우를 찾습니다
            //                {
            //                    orig = j;
            //                    break;
            //                }
            //            }
            //            //충돌상태가 없는 fcfs의 연산을 수행합니다
            //            addStamp(new Stamp(Ready[0].getName(), Ready[0].getArrivalTime(), currentTime += Ready[0].getBurstTime()));
            //            Console.WriteLine("stamp" + timestamp[timestamp.Count - 1].getStartTime() + "," + timestamp[timestamp.Count - 1].getEndTime());
            //            inputData[orig].setEndTime(currentTime);//프로세스가 종료되었음을 보장할 수 있으므로 프로세스 사망 시각을 기입합니다
            //            break;
            //    }                

            //    //Console.WriteLine("Ready[0]" + Ready[0].getName());                
            //    Ready.RemoveAt(0);
            //    for(int j=0;j<Ready.Count;j++){
            //        Console.WriteLine(Ready[j].getName());
            //    }
            //    //의미없이 들어간 프로세스 삭제
            //    if (Ready.Count > 0) 
            //    {
            //        if (Ready[0].getBurstTime() == 0)
            //            Ready.RemoveAt(0);
            //    }
            //    Console.ReadLine();
            //}

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
        int stmp_compare(Stamp a, Stamp b)    //스탬프의 정렬
        {
            if (a.getStartTime() > b.getStartTime())
                return 1;
            else if (a.getStartTime() == b.getStartTime())
                return 0;
            else
                return -1;
        }
    }
    
}

