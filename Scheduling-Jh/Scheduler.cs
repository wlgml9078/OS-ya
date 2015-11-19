using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduling_Jh
{
    class Scheduler
    {
        public int currentTime;
        private double ATT, AWT;
        public List<Process> inputData;
        private List<Stamp> timestamp;
        public Scheduler(List<Process> list){
            currentTime = 0;
            inputData = new List<Process>();
            timestamp = new List<Stamp>();
            inputData = list;
            ATT = 0.0;
            AWT = 0.0;
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
            for(int i=0; i<inputData.Capacity; i++)
            {
                sum += inputData[i].getEndTime()-inputData[i].getArrivalTime(); //각 반환시간 더함
            }

            ATT = sum / inputData.Capacity; //프로세스 수로 나누어줌

            return ATT;
        }

        public double getAWT()
        {
            int sum = 0;
            for (int i = 0; i < inputData.Capacity; i++)
            {
                sum += inputData[i].getEndTime() - inputData[i].getBurstTime(); //각 대기시간 더함
            }

            AWT = sum / inputData.Capacity; //프로세스 수로 나누어줌

            return AWT;
        }
    }

    public void showData()
    {
        console.
    }
}