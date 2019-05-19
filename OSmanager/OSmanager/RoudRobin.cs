using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSmanager
{
    class RoudRobin
    {
        private static int _Time = 20;

        public static void Execute(Process process)
        {
            int i = 0;
            while (!CPU.Execute(ref process) && i < _Time)
                i++;

            MMU.Translate(ref process);           
        }
    }
}
