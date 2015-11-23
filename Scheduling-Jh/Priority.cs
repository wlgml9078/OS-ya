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
        
        List<Process>[] temp;
        List<Process> Ready;
        public Priority(List<Process> list)
            :base(list)
        {
            Ready = new List<Process>();            
            /*
            for(int i=0; i<list.Count; i++)
            {
                Ready.Add(new Process(list[i].getName(),list[i].getArrivalTime(),list[i].getBurstTime(),list[i].getPriority()));    //큐 삽입
            }
            Ready.Sort(new Pri_Comparer());
            */
        }
        private bool isNowInStamp(int currentTime, List<Stamp> list)//currentTime이 스탬프에 찍혀있는 범위 내의 값인지 확인
        {
            bool check=false;
            for (int i = 0; i < list.Count; i++) 
            {
                if (currentTime > list[i].getStartTime() && currentTime < list[i].getEndTime())
                    check = true;
            }
            return check;
        }
        public void pri_run(bool preemptive) //그럼 내가 새로 짬.. ㅎㅎ
        {
            if (preemptive)//선점
            {
                //우선순위- 들어온순으로 정렬
                temp = new List<Process>[10];
                for (int i = 0; i < 10; i++)
                {
                    temp[i] = new List<Process>();
                }
                //들어온순-우선순위으로 정렬(기수정렬을 응용)
                inputData.Sort(pri_compare);//우선순위
                for (int i = 0; i < inputData.Count; i++)
                {
                    temp[inputData[i].getPriority()].Add(inputData[i]);//우선순위의 범위가 0-10 이므로 이렇게 했습니다
                }
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < temp[i].Count; j++)
                    {
                        Console.WriteLine("name:" + temp[i][j].getName());//저게 큐가 아니니까 이렇게 처리해야 순서대로 들어갑니다
                    }
                }
                
                for (int i = 0; i < 10; i++)
                {
                    temp[i].Sort(pro_compare);
                }
                inputData = new List<Process>();
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < temp[i].Count; j++)
                    {
                        inputData.Insert(0, temp[i][j]);//저게 큐가 아니니까 이렇게 처리해야 순서대로 들어갑니다
                    }
                }
                for (int i = 0; i < inputData.Count; i++)
                {   
                    Ready.Add(inputData[i]);//큐-에 들어온 순서대로 데이터를 넣었엉 이후 모든 처리는 큐를 기준으로 돌아감
                    Ready.Sort(pri_compare);//미안 사실 저거 리스트였어 정렬했으니까 이제 우선순위 큐랑 똑같음
                    if (isNowInStamp(Ready[0].getArrivalTime(), timestamp))//만약 다음 실행할 프로세스의 도착 시간이 먼저 찍힌(우선순위가 더 높은) 스탬프의 중간
                    {
                        if (currentTime > Ready[0].getArrivalTime())//현재 시간이 실행할 놈 도착시간보다 빠르면(겹치면)
                        {
                            addStamp(new Stamp(inputData[i].getName(), currentTime, (currentTime += inputData[i].getBurstTime()))); //현재시간으로 스탬프 쾅쾅
                        }
                        else
                        {
                            currentTime = Ready[0].getArrivalTime();
                            addStamp(new Stamp(inputData[i].getName(), currentTime, (currentTime += inputData[i].getBurstTime()))); //스탬프 쾅쾅
                        }
                        Ready.RemoveAt(0);//실행끝난놈은 죽여
                        inputData[i].setEndTime(currentTime);//너 프로세스는 여기서 죽었다
                    }
                }
            }
            else//비선점
            {
                temp=new List<Process>[10];
                for (int i = 0; i < 10; i++) {
                    temp[i] = new List<Process>();
                }
                //들어온순-우선순위으로 정렬(기수정렬을 응용)
                inputData.Sort(pro_compare);//들어온 순으로 정렬
                for (int i = 0; i < inputData.Count; i++)
                {
                    temp[inputData[i].getArrivalTime()].Add(inputData[i]);//도착시간의 범위가 0-10 이므로 이렇게 했습니다
                }
                for (int i = 0; i < 10; i++) 
                {
                    temp[i].Sort(pri_compare);
                }
                inputData=new List<Process>();
                for (int i = 0; i < 10; i++) {
                    for (int j = 0; j < temp[i].Count; j++) {
                        inputData.Insert(0,temp[i][j]);//저게 큐가 아니니까 이렇게 처리해야 순서대로 들어갑니다
                    }
                }                
                for (int i = 0; i < inputData.Count; i++)//즉 시간순으로 처리됩니다
                {
                    Ready.Add(inputData[i]);//리스트에 들어온 순서대로 데이터를 넣었습니다 이후 모든 처리는 큐를 기준으로 돌아갑니다
                    Ready.Sort(pri_compare);//큐가 아닌 리스트이므로 리스트를 큐처럼 만들기 위해 정렬을 합니다.
                    if (currentTime > Ready[0].getArrivalTime())//현재 시간이 실행할 놈 도착시간보다 빠르면(겹치면)
                    {
                        addStamp(new Stamp(inputData[i].getName(), currentTime, (currentTime += inputData[i].getBurstTime()))); //스탬프 쾅쾅
                    }
                    else
                    {
                        currentTime = Ready[0].getArrivalTime();
                        addStamp(new Stamp(inputData[i].getName(), currentTime, (currentTime += inputData[i].getBurstTime()))); //스탬프 쾅쾅
                    }
                    Ready.RemoveAt(0);//실행끝난 프로세스는 죽입니다
                    inputData[i].setEndTime(currentTime);//프로세스의 묘비명을 적어줍니다
                }

            }
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
        public int pri_compare(Process a, Process b)
        {
            if (a.getPriority() > b.getPriority())
                return -1;
            else if (a.getArrivalTime() == b.getArrivalTime())
                return 0;
            else
                return 1;
        }
    }
}
