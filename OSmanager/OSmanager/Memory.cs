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

        private static int cont = 0;

        public static void InitializeProcess(Process MyProcess)
        {
            if (MyProcess.Size + Length <= Capacity)
            {
                Length += MyProcess.Size;
                cont++;
                Ram.Enqueue(MyProcess);
            }
            else
            {
                VirtualMemory.InitializeProcess(MyProcess);
            }
        }

        public static bool MemoryFull(int ProcessSize)
        {
            return Length + ProcessSize > Capacity;
        }

        public static Process KillProcess()
        {
            Process temp = Ram.Dequeue();
            Length -= temp.Size;
            cont--;
            return temp;
        }

        public static Queue<Process> QProcess()
        {
            return Ram;
        }

        public static bool EmptyProcessUser()
        {
            return cont == 0;
        }



    }
}
