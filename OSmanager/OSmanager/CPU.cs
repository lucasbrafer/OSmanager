using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace OSmanager
{
    class CPU
    {
        Process _Process;

        public int MyProperty { get; set; }
        public int _Clock { get; protected set; }
        public int _Adress { get; protected set; }

        public CPU(int Clock, Process MyProcess)
        {
            _Clock = Clock;
            _Process = MyProcess; 
        }

        public bool Execute()
        {
            if (_Process.Ready())
                return true;

            System.Threading.Thread.Sleep(1000);
            _Process.ReduceTime();
            return false;

        }

    }
}
