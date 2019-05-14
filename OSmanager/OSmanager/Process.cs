using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSmanager
{
    class Process
    {
        public int TimeExecuted { get; private set; }
        public string Status { get; private set; }
        public string _Name { get; private set; }
        public int _Size { get;  private set; }

        public Process(string Name, int Size)
        {
            _Name = Name;
            _Size = Size;
            Status = "Waiting";
        }
    }
}
