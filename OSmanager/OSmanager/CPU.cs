using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace OSmanager
{
    class CPU
    {
        public static bool Execute(ref Process process)
        {
            //erro de ao usar esses metodos stack overflow
            //if (process.Ready())
            //    return true;

            //process.ReduceTime();
            //return false;

            if (process.Size == 0)
                return true;
            else
            {
                process.Size -= 1;
                return false;
            }
            
        }
    }
}
