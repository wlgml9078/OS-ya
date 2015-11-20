﻿using System;
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
        public int getTimeGap()
        {
            return endtime - starttime; 
        }
        public void print()
        {
            Console.WriteLine("s"+this.name+":"+starttime+","+endtime);
        }
        public String getName() { return name; }
    }
}
