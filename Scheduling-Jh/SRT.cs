using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduling_Jh
{
    class SRT :Scheduler    //선점방식 사용
    {
        Queue<Process> Queue;   //레디큐
        List<Process> Ready;

        public SRT(List<Process> list)
            :base(list)
        {
            Queue = new Queue<Process>();
            Ready = new List<Process>();
            currentTime = 0;

            for (int i = 0; i < inputData.Count; i++)   //큐에 리스트 복사
            {
                Process p = new Process(list[i].getName(), list[i].getArrivalTime(), list[i].getBurstTime());
                Queue.Enqueue(p);
            }
        }
        public void srt_run() { 

        }
        public void srt_alg()
        {
            int start = 0, remained = 0, end = 0;
            Process p = null;

            while (Queue.Count > 0 || Ready.Count > 0)
            {
                Console.WriteLine("Count:" + Queue.Count);
                
                while (Queue.Count > 0 && Queue.Peek().getArrivalTime() >= currentTime)
                {
                    Ready.Add(Queue.Dequeue());
                    Ready.Sort(new Comparer(2));
                }

                if (p == null && Ready.Count > 0)
                {
                    Console.WriteLine("들어감 "+currentTime);
                    p = Ready.First();
                    start = currentTime;
                }

                if (p != null)
                {
                    if (Ready.Exists(x => (x.getBurstTime() >= p.getBurstTime())))    //레디큐에서 우선순위가 더 높은 프로세스 발견
                    //if(Ready.Exists(x=>(x.getArrivaltime()<=p.getBurstTime()+currentTime) 이 경우 추가하기☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆
                    {
                        Console.WriteLine("들어감1 " + currentTime);
                        Process next = Ready.Find(x => (x.getBurstTime() >= p.getBurstTime()));

                        remained = start + next.getBurstTime() - next.getArrivalTime();
                        currentTime = next.getArrivalTime();
                        end = currentTime;
                        Stamp s = new Stamp(p.getName(), start, end);
                        addStamp(s);
                        if (end - start != 0)
                        {
                            Process newP = new Process(p.getName(), p.getArrivalTime(), p.getBurstTime());
                            Ready.Add(newP);
                            Console.WriteLine("들어감2 " + currentTime);
                        }
                        else
                        {
                            Console.WriteLine("들어감3 " + currentTime);
                            for (int i = 0; i < inputData.Count; i++)
                            {
                                if (inputData[i].getName().Equals(p.getName()))
                                {
                                    Console.WriteLine(i+":들어감4");
                                    inputData[i].setEndTime(end);
                                }
                                Console.WriteLine("들어감5");
                            }
                        }
                        Ready.Remove(p);
                        p = next;
                    }
                    else
                    {
                        Console.WriteLine("들어감6");
                        if (p!=null && start + p.getBurstTime() - currentTime <= p.getBurstTime())
                        {
                            end = currentTime;
                            for (int i = 0; i < inputData.Count; i++)
                            {
                                if (inputData[i].getName().Equals(p.getName()))
                                {
                                    inputData[i].setEndTime(end);
                                    Console.WriteLine("들어감7");
                                }
                                Stamp s = new Stamp(p.getName(), start, end);
                                addStamp(s);

                                Ready.Remove(p);
                                p = null;
                                Console.WriteLine("들어감8");
                            }
                        }
                    }
                }
                //Console.WriteLine("나옴");
                currentTime++;
            }
        }
    }
}
