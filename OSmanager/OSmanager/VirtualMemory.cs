using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSmanager
{
    class VirtualMemory
    {
        public static Queue<Process> VM = new Queue<Process>();

        public static void InitializeProcess(Process MyProcess)
        {
            VM.Enqueue(MyProcess);
        }

        public static void KillProcess()
        {
            VM.Dequeue();
        }

    }
}
