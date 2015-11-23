//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace Scheduling_Jh
//{
//    class HRN :Scheduler
//    {
//        Queue<Process_HRN> Ready;

//        public HRN(List<Process> list)
//            :base(list)
//        {
//            Ready = new Queue<Process_HRN>();
//            for(int i=0; i<inputData.Count; i++)
//            {
//                Process_HRN p = new Process_HRN(inputData[i].getName(), inputData[i].getArrivalTime(), inputData[i].getBurstTime());
//                Ready[i].Enqueue(p);
//            }
//        }

//        void hrn_alg()
//        {

//        }
//    }
//}