using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace OSmanager
{
    class FCFS
    {
        public static void Execute(Process process)
        {
            while (!CPU.Execute(ref process))

            MMU.Translate(ref process,process.Size);
        }
    }
}
