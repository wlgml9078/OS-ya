﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduling_Jh
{
    class Comparer : IComparer<Process>
    {
        int flag;

        public Comparer(int flag)
        {
            this.flag = flag;
        }

        public int Compare(Process x, Process y)
        {
            switch(flag)
            { 
                case 0:
                    return x.getArrivalTime().CompareTo(y.getArrivalTime());
                case 1:
                    return x.getPriority().CompareTo(y.getPriority());
                default:
                    return x.getBurstTime().CompareTo(y.getBurstTime());
            }
        }
    }

    class Comparer_HRN : IComparer<Process_HRN>
    {
        public int Compare(Process_HRN x, Process_HRN y)
        {
            return x.getPriority().CompareTo(y.getPriority()); 
        }
    }

    class Scheduler
    {
        public int currentTime;
        private double ATT, AWT;
        private int last_end;//스케줄러가 가진 최근의 종료 시점
        public List<Process> inputData;
        protected List<Stamp> timestamp;
        public Scheduler(List<Process> list){
            timestamp= new List<Stamp>();
            currentTime = 0;

            inputData = new List<Process>();
            timestamp = new List<Stamp>();
            inputData = list;
            inputData.Sort(new Comparer(0));
            ATT = 0;
            AWT = 0;
        }
        public void addStamp(Stamp stamp) {
            timestamp.Add(stamp);
        }
        public List<Stamp> getTimestamp() {
            return timestamp;
        }
        public int SortStampInTime(Stamp a, Stamp b)//오름차순으로 찍힌 시간순으로 정렬
        {
            if (a.getStartTime() > b.getStartTime())
                return 1;
            else if (a.getStartTime() == b.getStartTime())
                return 0;
            else
                return -1;
        }
        public int pro_compare(Process a, Process b)//내림차순으로 온 순서대로 정렬
        {
            if (a.getArrivalTime() > b.getArrivalTime())
                return 1;
            else if (a.getArrivalTime() == b.getArrivalTime())
                return 0;
            else
                return -1;
        }
        public int pro_compare_desc(Process a, Process b)//오름차순으로 온 순서대로 정렬
        {
            if (a.getArrivalTime() > b.getArrivalTime())
                return -1;
            else if (a.getArrivalTime() == b.getArrivalTime())
                return 0;
            else
                return 1;
        }
        //추가
        public double getATT()
        {
            int sum=0;
            int data = 0;

            for(int i=0; i<inputData.Count; i++)
            {
                data = inputData[i].getEndTime() - inputData[i].getArrivalTime();
                Console.WriteLine(inputData[i].getName()+":"+inputData[i].getEndTime()+","+inputData[i].getArrivalTime());
                sum += data; //각 반환시간 더함
            }

            ATT = Convert.ToDouble(sum) / inputData.Count; //프로세스 수로 나누어줌

            return ATT;
        }

        public double getAWT()
        {
            int sum = 0;
            int data = 0;

            for (int i = 0; i < inputData.Count; i++)
            {
                data = inputData[i].getEndTime() - inputData[i].getArrivalTime() - inputData[i].getBurstTime();
                Console.WriteLine("data:" + data);
                sum += data;
            }

            AWT = Convert.ToDouble(sum) / inputData.Count; //프로세스 수로 나누어줌

            return AWT;
        }
    }

}