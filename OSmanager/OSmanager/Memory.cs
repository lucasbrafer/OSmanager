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

        private int LastSize;

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
            Busy = Math.Ceiling(Busy);

            if (BusyPages + Busy < TotalPages)
            {
                LastSize = BusyPages;
                BusyPages +=  Convert.ToInt32(Busy);
                return true;
            }
            else
                return false;
        }


        public bool InitializeProcess(Process MyProcess)
        {
            if (SpaceWritable(MyProcess._Size))
            {
                for (int i = 0; i < LastSize; i++)
                    Ram.Enqueue(MyProcess);

                return true;
            }
            else
                return false;
        
        }

        public void KillProcess(Process MyProcess)
        {
            Ram.Dequeue();
        }

        public Queue<Process> Queue()
        {
            return Ram;
        }
    }
}
