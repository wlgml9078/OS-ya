using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduling_Jh
{
    class Scheduler
    {
        public int currentTime;
        public List<Process> inputData;
        private List<Stamp> timestamp;
        public Scheduler(List<Process> list){
            currentTime = 0;
            inputData = new List<Process>();
            inputData = list;
        }
        public void addStamp(Stamp stamp) {
            timestamp.Add(stamp);
        }
        public List<Stamp> getTimestamp() {
            return timestamp;
        }

        //추가된 부분
        //public void addProcess(Process p)   //프로세스 추가
        //{
        //    inputData.Add(p);
        //}
        public double getAWT()  //awt 구하기
        {
            return 0.0;
        }
        public double getATT()  //att 구하기
        {
            return 0.0;
        }
    }
}