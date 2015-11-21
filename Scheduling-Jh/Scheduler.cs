using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduling_Jh
{
    class Burst_Comparer : IComparer<Process>
    {
        public int Compare(Process x, Process y)
        {
            return x.getBurstTime().CompareTo(y.getBurstTime());
        }
    }

    class Comparer : IComparer<Process>
    {
        public int Compare(Process x, Process y)
        {
            return x.getArrivalTime().CompareTo(y.getArrivalTime());
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
            inputData.Sort(new Comparer());
            ATT = 0;
            AWT = 0;
        }
        public void addStamp(Stamp stamp) {
            timestamp.Add(stamp);
        }
        public List<Stamp> getTimestamp() {
            return timestamp;
        }

        //추가
        public double getATT()
        {
            int sum=0;
            int data = 0;

            for(int i=0; i<inputData.Count; i++)
            {
                data = inputData[i].getEndTime() - inputData[i].getArrivalTime();
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
                sum += data;
            }

            AWT = Convert.ToDouble(sum) / inputData.Count; //프로세스 수로 나누어줌

            return AWT;
        }
    }

}