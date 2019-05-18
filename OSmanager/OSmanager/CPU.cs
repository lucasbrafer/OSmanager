using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace OSmanager
{
    class CPU
    {
        public static bool Execute(Process process)
        {
            if (process.Ready())
                return true;

            System.Threading.Thread.Sleep(1000);
            process.ReduceTime();
            return false;
        }
    }
}
