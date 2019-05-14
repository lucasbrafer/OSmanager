using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSmanager
{
    class CPU
    {
        public int MyProperty { get; set; }
        public int _Clock { get; private set; }
        public int _Adress { get; private set; }

        public CPU(int Clock)
        {
            _Clock = Clock;
        }

    }
}
