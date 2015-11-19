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
    }

}
