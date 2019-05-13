using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSmanager
{
    class Memory
    {
        private Queue<Process> Ram;

        private int TotalPages;
        public int _SizePages { get; private set; }

        public Memory(int Size)
        {
            _SizePages = Size;
            Ram = new Queue<Process>();
            TotalPages = 1024 / Size;
        }

        public void InitializeProcess(Process MyProcess)
        {
            Ram.Enqueue(MyProcess);
        }

        public void KillProcess(Process MyProcess)
        {
            Ram.Dequeue();
        }

    }
}
