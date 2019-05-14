using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSmanager
{
    class MMU
    {
        public Process _process { get; private set; }

        private Memory Ram;

        public MMU(Memory myRam, Process process)
        {
            Ram = myRam;
            _process = process;
        }

        public void Translate()
        {
            if (_process._Size == 0)
            {
                _process.Ready();
            }

            Ram.InitializeProcess(_process);
        }


    }
}
