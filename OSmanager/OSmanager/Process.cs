using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSmanager
{
    class Process
    {
        public int Time { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }

        public bool Ready()
        {
            return Time == 0;
        }

        public void ReduceTime()
        {
            Time = Time -1;
        }

    }
}
