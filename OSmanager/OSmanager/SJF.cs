using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSmanager
{
    class SJF
    {
        private CPU cpu;

        private Queue<Process> Ram;

        private int TimeRR;

        public SJF(CPU MyCpu, Queue<Process> MyRam)
        {
            cpu = MyCpu;
            Ram = MyRam;
        }

        public void Execute()
        {
            
        }
    }
}
