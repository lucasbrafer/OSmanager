using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSmanager
{
    class MMU
    {
        public static void Translate(Process process)
        {

            Memory.InitializeProcess(process);

        }
    }
}
