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

        private int BusyPages;

        public int _Capacity { get; private set; }
        public int _SizePages { get; private set; }

        public Memory(int SizePages)
        {
            _SizePages = SizePages;
            _Capacity = 1024;

            TotalPages = SizePages % _Capacity;
            BusyPages = 0;

            Ram = new Queue<Process>();
           
        }

        public bool SpaceWritable(int Size)
        {
            double Busy = Size / _SizePages;

            if (BusyPages + Math.Ceiling(Busy) < TotalPages)
                return true;
            else
                return false;
        }


        public void InitializeProcess(Process MyProcess)
        {
            if (SpaceWritable(MyProcess._Size))
                Ram.Enqueue(MyProcess);                
        }

        public void KillProcess(Process MyProcess)
        {
            Ram.Dequeue();
        }

    }
}
