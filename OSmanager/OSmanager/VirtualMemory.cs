using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSmanager
{
    class VirtualMemory
    {
        private static int cont = 0;

        public static Queue<Process> VM = new Queue<Process>();

        public static void InitializeProcess(Process MyProcess)
        {
            VM.Enqueue(MyProcess);
            cont++;
        }

        public static Process KillProcess()
        {
            cont--;
            return VM.Dequeue();
        }

        public static bool Empyt()
        {
            return cont == 0;
        }

        public static int FirstLenght()
        {
            int temp = 0;
            foreach (Process x in VM)
            {
                temp = x.Size;
                break;
            }
            return temp;
        }

    }
}
