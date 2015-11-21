using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduling_Jh
{
    public class Stamp
    {
        String name;
        int starttime;
        int endtime;
        int remained;   //남은 BURST TIME

        public Stamp(string name, int startpoint, int endpoint) //비선점인 경우
        {
            this.name = name;
            this.starttime = startpoint;
            this.endtime = endpoint;
            this.remained = 0;
        }
        public Stamp(string name, int startpoint, int endpoint, int remained) //선점인 경우
        {
            this.name = name;
            this.starttime = startpoint;
            this.endtime = endpoint;
            this.remained = remained;
        }
        public int getTimeGap()
        {
            return endtime - starttime; 
        }
        public int getRemained()
        {
            return remained;
        }
        public void print()
        {
            Console.WriteLine("s"+this.name+":"+starttime+","+endtime);
        }
        public String getName() { return name; }
    }
}
