using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduling_Jh
{
    class Stamp
    {
        String name;
        int starttime;
        int endtime;
        public Stamp(string name, int startpoint, int endpoint) 
        {
            this.name = name;
            this.starttime = startpoint;
            this.endtime = endpoint;
        }
        public String getName(){
            return name;
        }
        public int getStartTime() {
            return starttime;
        }
        public int getEndTime() {
            return endtime;
        }
    }
}
