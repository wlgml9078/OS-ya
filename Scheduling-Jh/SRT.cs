using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduling_Jh
{
    class SRT :Scheduler    //선점방식 사용
    {
<<<<<<< HEAD
        List<Process> Ready;
        List<Process> Copy;
=======
        int max_num;
        List<Process> Ready;
        Queue<Process> queue;
>>>>>>> origin/master
        public SRT(List<Process> list)
            :base(list)
        {
            currentTime = 0;
            Ready = new List<Process>();
<<<<<<< HEAD
            Copy = list;
        }

        //private int isNowInStamp(Process p, List<Stamp> list)//currentTime이 스탬프에 찍혀있는 범위 내의 값인지 확인
        //{
            
        //    bool is_start_dup=false;
        //    bool is_end_dup=false;
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        Console.WriteLine("searching process:str:" + list[i].getStartTime() + " end" + list[i].getEndTime());
        //        if ((list[i].getStartTime() <= p.getArrivalTime()) && (list[i].getEndTime() > p.getArrivalTime()))
        //        {                    
        //            is_start_dup = true;
        //            break;
        //        }
        //        //if(p.getArrivalTime()>=list[i].getStartTime()&&p.getArrivalTime()<list[i].getEndTime())
        //        //    is_start_dup=true;

        //        if (list[i].getStartTime() <= p.getArrivalTime() + p.getBurstTime() && list[i].getEndTime() >= p.getArrivalTime() + p.getBurstTime())
        //        {
        //            is_end_dup = true;
        //        }
        //        //if (p.getArrivalTime() + p.getBurstTime() >= list[i].getStartTime() && p.getArrivalTime() + p.getBurstTime() <= list[i].getEndTime())
        //        //    is_end_dup=true;
        //        if(p.getArrivalTime()<list[i].getStartTime()&&p.getArrivalTime()+p.getBurstTime()>list[i].getEndTime())
        //            return 0;
        //        if (p.getArrivalTime() > list[i].getStartTime() && p.getArrivalTime() + p.getBurstTime() < list[i].getEndTime())
        //            return 1;
        //    }
        //    if(is_start_dup){
        //        return 1;
        //    }
        //    else if(is_end_dup){
        //        return 0;
        //    }
        //    else{
        //        return 2;
        //    }
            
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
        //}        
        public void srt_run()
        {
            int remain = 0, smallest;
            int time;
            int[] remain_times = new int[10];
=======
            queue = new Queue<Process>();
            for(int i=0; i<inputData.Count; i++)
            {
                queue.Enqueue(new Process(inputData[i].getName(), inputData[i].getArrivalTime(), inputData[i].getBurstTime()));
            }
        }
        /*private int isNowInStamp(Process p, List<Stamp> list)//currentTime이 스탬프에 찍혀있는 범위 내의 값인지 확인
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
        } */

        /*private void Sorting()
        {
            temp = new List<Process>[max_num + 1];
            for (int i = 0; i < max_num + 1; i++)
            {
                temp[i] = new List<Process>();
            }
            //들어온순-우선순위으로 정렬(기수정렬을 응용)
            inputData.Sort(bur_compare);//우선순위
            for (int i = 0; i < inputData.Count; i++)
            {
                temp[inputData[i].getBurstTime()].Add(inputData[i]);//우선순위의 범위가 1-10 이므로 이렇게 했습니다
            }
>>>>>>> origin/master

            for (int i = 0; i < Copy.Count; i++)
            {
                remain_times[i] = Copy[i].getBurstTime();
            }
            remain_times[9] = 999;

            for (time = 0; remain != Copy.Count; time++)
            {
                Console.WriteLine("time = " + time);
                smallest = 9;
                for (int i = 0; i < Copy.Count; i++)
                {
                    if ((Copy[i].getArrivalTime() <= time) && (remain_times[i] < remain_times[smallest]) && (remain_times[i] > 0))
                    {
                        smallest = i;
                    }
                }
                timestamp.Add(new Stamp(inputData[smallest].getName(), time, time + 1));
                remain_times[smallest]--;
                Console.WriteLine("remain:" + remain_times[smallest]);
                if (remain_times[smallest] == 0)
                {
<<<<<<< HEAD
                    remain++;
                    inputData[smallest].setEndTime(time + 1);
                    Console.WriteLine(inputData[smallest].getName() +" " + inputData[smallest].getEndTime());
                }
            }
            //스탬프 합치기
            for (int i = 0; i < timestamp.Count-1;i++ ) {
                               
                if(timestamp[i].getName().CompareTo(timestamp[i+1].getName())==0){
                    Stamp newStamp=new Stamp(timestamp[i].getName(),timestamp[i].getStartTime(),timestamp[i+1].getEndTime());
                    timestamp.RemoveAt(i);
                    timestamp.RemoveAt(i);
                    timestamp.Insert(i, newStamp);
                    i--;
                }

            }
        }
            //Copy.Sort(pro_compare);
            //for (int i = 0; i < Copy.Count; i++) {
            //    Console.WriteLine("Current"+ Copy[0].getName()+" arr:"+Copy[0].getArrivalTime()+" bur"+Copy[0].getBurstTime());
                
            //    temp = new List<Process>[20];
            //    for (int j = 0; j < 20; j++) {
            //        temp[j] = new List<Process>();
            //    }
            //    Copy.Sort(bur_compare);
            //    for (int j = 0; j < Copy.Count; j++)
            //    {
            //        temp[Copy[j].getArrivalTime()].Insert(0,Copy[j]);
            //    }
            //    Copy= new List<Process>();
            //    for (int j = 0; j < 20; j++)
            //    {
            //        for (int l = 0; l < temp[j].Count; l++)
            //        {
            //            Copy.Add(temp[j][l]);
            //        }
            //    }
            //    //for (int j = 0; j < Copy.Count; j++)
            //    //{
            //    //    Console.WriteLine(Copy[j].getName() + " " + Copy[j].getArrivalTime() + " " + Copy[j].getBurstTime());
            //    //}

            //    //who are you?
            //    int index = 0;
            //    for (int j = 0; j < inputData.Count; j++)
            //    {
            //        if (Copy[0].getName().CompareTo(inputData[j].getName()) == 0)
            //        {
            //            index = j;
            //        }
            //    }
            //    if (i<Copy.Count-1)//비교할 다음 프로세스가 존재
            //    {    
                    
                   

            //        if (Copy[0].getBurstTime()+Copy[0].getArrivalTime()<= Copy[1].getArrivalTime())
            //            //다음 프로세스의 시작시간과 겹치지 않은 경우
            //        {
            //            Console.WriteLine("case 0");
            //            timestamp.Add(new Stamp(Copy[0].getName(), Copy[0].getArrivalTime(), Copy[0].getArrivalTime() + Copy[0].getBurstTime()));
            //            Console.WriteLine("stamp " + Copy[0].getName() + " " + Copy[0].getArrivalTime() + " " + (Copy[0].getArrivalTime() + Copy[0].getBurstTime()));
            //            inputData[index].setEndTime(Copy[0].getArrivalTime() + Copy[0].getBurstTime());
            //            currentTime += Copy[0].getBurstTime();
            //        }
            //        else
            //        {
            //            for (int j = 0; j < Copy.Count; j++) { 
            //                if()
            //            }
            //            //겹쳤는데 잘린 경우
            //            if (Copy[0].getBurstTime() - Copy[1].getArrivalTime() > Copy[1].getBurstTime())
            //            {
            //                Console.WriteLine("case 1-1");
            //                //앞부분은 스탬프
            //                timestamp.Add(new Stamp(Copy[0].getName(), Copy[0].getArrivalTime(), Copy[0].getArrivalTime()));
            //                Console.WriteLine("stamp " + Copy[0].getName() + " " + Copy[0].getArrivalTime() + " " + Copy[1].getArrivalTime());
            //                //뒷부분은 새 프로세스
            //                Copy.Insert(2, new Process(Copy[0].getName(), Copy[1].getArrivalTime() + Copy[1].getBurstTime(), Copy[0].getBurstTime() - (Copy[1].getArrivalTime())));
            //                Console.WriteLine("insert " + Copy[0].getName() + " " + (Copy[1].getArrivalTime() + Copy[1].getBurstTime()) + " " + (Copy[0].getBurstTime() - (Copy[1].getArrivalTime())));
            //            }
            //            //겹쳤는데 뒤에꺼가 밀린 경우(다 밀어내기)
            //            else
            //            {
            //                Console.WriteLine("case 1-2");
            //                //미룬 프로세스 삽입
            //                for (int j = Copy.Count - 1; j > 1; j--)
            //                {
            //                    Copy.Insert(j, new Process(Copy[j].getName(), Copy[j].getArrivalTime() + Copy[0].getBurstTime(), Copy[j].getBurstTime()));
            //                    Console.WriteLine("Insert " + Copy[j].getName() + " " + (Copy[j].getArrivalTime() + Copy[0].getBurstTime()) + " " + (Copy[j].getBurstTime()));
            //                    //다음 프로세스 종료
            //                    Copy.RemoveAt(j + 1);
            //                }
            //                //현재 프로세스 스탬프
            //                timestamp.Add(new Stamp(Copy[0].getName(), Copy[0].getArrivalTime(), (Copy[0].getArrivalTime() + Copy[0].getBurstTime())));
            //                Console.WriteLine("stamp " + Copy[0].getName() + " " + Copy[0].getArrivalTime() + " " + (Copy[0].getArrivalTime() + Copy[0].getBurstTime()));

            //            }
            //        }
            //        Copy.RemoveAt(0);
            //        temp = new List<Process>[20];
            //        for (int j = 0; j < 20; j++)
            //        {
            //            temp[j] = new List<Process>();
            //        }
            //        Copy.Sort(bur_compare);
            //        for (int j = 0; j < Copy.Count; j++)
            //        {
            //            temp[Copy[j].getArrivalTime()].Insert(0, Copy[j]);
            //        }
            //        Copy = new List<Process>();
            //        for (int j = 0; j < 20; j++)
            //        {
            //            for (int l = 0; l < temp[j].Count; l++)
            //            {
            //                Copy.Add(temp[j][l]);
            //            }
            //        }                 
                    
            //        Console.WriteLine("Ready");
            //        for (int j = 0; j < Copy.Count; j++)
            //        {
            //            Console.WriteLine(Copy[j].getName()+" "+Copy[j].getArrivalTime()+" "+Copy[j].getBurstTime());
            //        }
            //        Console.WriteLine("Ready");
            //        Console.ReadLine();
            //    }
            //    else 
            //    { 
            //        Console.WriteLine("case -1*******************");
            //        {
            //            timestamp.Add(new Stamp(Copy[0].getName(), Copy[0].getArrivalTime(), Copy[0].getArrivalTime() + Copy[0].getBurstTime()));
            //            Console.WriteLine("stamp " + Copy[0].getName() + " " + Copy[0].getArrivalTime() + " " + (Copy[0].getArrivalTime() + Copy[0].getBurstTime()));
            //            inputData[index].setEndTime(Copy[0].getArrivalTime() + Copy[0].getBurstTime());                    
            //        }
            //    }
            //}
            //********************************************************************************************************************
            //********************************************************************************************************************
            //******        ********          *****          ***          **         *****     ****  *****        ***      *******
            //******  ******  ******  *************  *******  **  ******  **  **********  ********    *******  ******  ***********
            //******  *******  *****  *************  *******  **  ******  **  *********  ********  **  ******  ******  ***********
            //******  *******  *****  *************  *******  **  ***    ***  *********  ********  **  ******  ******  ***********
            //******  *******  *****          *****         ****     *******         **  *******       ******  ******      *******
            //******  *******  *****  *************  ***********  ***  *****  *********  *******  ****  *****  ******  *********** 
            //******  ******  ******  *************  ***********  *****  ***  **********  ******  ****  *****  ******  ***********
            //******         *******          *****  ***********  *****  ***         ****     **  ****  *****  ******       ******
            //********************************************************************************************************************
            //********************************************************************************************************************
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

        //}
        
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
=======
                    inputData.Add(temp[i][j]);//저게 큐가 아니니까 이렇게 처리해야 순서대로 들어갑니다
                    Ready.Add(temp[i][j]);
                    Console.WriteLine(temp[i][j].getName()+","+temp[i][j].getBurstTime());
                }
            }
        }*/

        /*private void StampProcess(Process p)
        {
            int type = isNowInStamp(p,timestamp);
            Stamp s;
            int startpoint=0, endpoint=0;
            Process tmp, next;
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

                    tmp = new Process(p.getName(), endpoint, n_burst);
                    Ready.Add(tmp);
                    Ready.RemoveAt(0);
                    Sorting();
                    s = new Stamp(p.getName(), p.getArrivalTime(), startpoint);
                    addStamp(s);
                    next = Ready.First();
                    StampProcess(next);
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
                    tmp = new Process(p.getName(), endpoint, p.getBurstTime());
                    Ready.Add(tmp);
                    Ready.RemoveAt(0);
                    Sorting();
                    next = Ready.First();
                    StampProcess(next);
                    Console.WriteLine("<type 1 end>");
                    break;
                case 2:
                    Console.WriteLine("<type 2>");
                    int end = p.getArrivalTime() + p.getBurstTime();
                    s = new Stamp(p.getName(), p.getArrivalTime(), end);
                    addStamp(s);
                    Ready.RemoveAt(0);
                    for (int i = 0; i < inputData.Count; i++ )
                    {
                        if (inputData[i].getName().Equals(s.getName()))
                        {
                            inputData[i].setEndTime(end);
                        }
                    }
                    Sorting();
                    Console.WriteLine("<type 2 end>");
                    break;
            }
        }*/

        private void Sorting(int start, int end)
        {
            for(int i=0; i<queue.Count; i++)
            {
                if(queue.Peek().getArrivalTime()>=start && queue.Peek().getArrivalTime()<end)
                {
                    Ready.Add(queue.Dequeue());
                }
            }
        }
        public void srt_alg(Process p)
        {
            Console.WriteLine("::str_alg start");
            if(Ready.First().getBurstTime()<p.getBurstTime())
            {
                Console.WriteLine(Ready.First().getBurstTime() + " vs " + p.getBurstTime());
                p.setBurstTime(p.getBurstTime() + p.getArrivalTime() - Ready.First().getArrivalTime());
                Ready.Add(p);
                Ready.Sort(new Comparer(1));
                Stamp s = new Stamp(p.getName(), Ready.First().getArrivalTime(), p.getBurstTime());
                addStamp(s);
                currentTime += s.getEndTime();
                Console.WriteLine(s.getName() + "," + s.getStartTime() + "," + s.getEndTime());
                srt_alg(p);
            }
            else
            {
                Stamp s = new Stamp(p.getName(), p.getArrivalTime(), p.getBurstTime());
                addStamp(s);
                currentTime += s.getEndTime();
            }
            Console.WriteLine("::str_alg end");
        }
        public void srt_run()
        {
            Console.WriteLine(":str_run");
            do
            {
                for (int i = 0; i < queue.Count; i++)
                {
                    if (queue.Peek().getArrivalTime() <= currentTime)
                    {
                        Ready.Add(queue.Dequeue());
                    }
                }
                Ready.Sort(new Comparer(1));
                for (int i = 0; i < Ready.Count; i++ )
                {
                    Console.WriteLine(Ready[i].getName() + "," + Ready[i].getArrivalTime() + "," + Ready[i].getBurstTime());
                }
                if (currentTime >= Ready.First().getArrivalTime())
                {
                    Process p = Ready.First();
                    Ready.RemoveAt(0);
                    srt_alg(p);
                }
                else currentTime++;
            }
            while (Ready.Count > 0 && queue.Count > 0);
        }

>>>>>>> origin/master
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

