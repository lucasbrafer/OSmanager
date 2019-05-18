using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSmanager
{
    class Memory
    {
        public static Queue<Process> Ram = new Queue<Process>();

        public static double Capacity = 1024;

        public static double Length = 1024 * 0.2; 

        public static void InitializeProcess(Process MyProcess)
        {
            Length += MyProcess.Size;
            Ram.Enqueue(MyProcess);
        }

        public static bool MemoryFull(int ProcessSize)
        {
            return Length + ProcessSize >= Capacity;
        }

        public static Process KillProcess()
        {
            Process temp = Ram.Dequeue();
            Length -= temp.Size;
            return temp;
        }

        public static Queue<Process> QProcess()
        {
            return Ram;
        }


    }
}
