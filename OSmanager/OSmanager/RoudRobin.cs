using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSmanager
{
    class RoudRobin
    {
        private CPU cpu;

        private int TimeRR;

        public RoudRobin(CPU MyCpu, int Time)
        {
            TimeRR = Time;
            cpu = MyCpu;
        }

        public void Execute()
        {
            int i = 0;
            while (!cpu.Execute() && i < TimeRR)
                i++;                        
        }
    }
}
