using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSmanager
{
    class MMU
    {
        public static void Translate(ref Process process, int size)
        {
            process.Size = size;

            if (size > 0)
            {
                Memory.InitializeProcess(process);
            }
        }
    }
}
