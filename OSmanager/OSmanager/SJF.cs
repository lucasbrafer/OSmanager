using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSmanager
{
    class SJF
    {
        public void Execute(Process process)
        {
            int menor = int.MaxValue;
            int i = 0;

            foreach (Process x in Memory.Ram)
                if (menor > x.Time)
                    menor = x.Time;

            Process temp;

            foreach (Process x in Memory.Ram)
                if (menor == x.Time)
                {
                    temp = x;
                    break;
                }

            while (!CPU.Execute(process))
                i++;

            MMU.Translate(process);
        }
    }
}
