using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSmanager
{
    class RoudRobin
    {
        public static int _Time { get; private set; }

        public RoudRobin(int Time)
        {
            _Time = Time;
        }

        public static void Execute(Process process)
        {
            int i = 0;
            while (!CPU.Execute(process) && i < _Time)
                i++;

            MMU.Translate(process);           
        }
    }
}
