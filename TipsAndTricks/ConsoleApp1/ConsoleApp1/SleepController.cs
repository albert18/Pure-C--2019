using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SleepController : ISleep
    {
        public bool isSleeping { get; private set; }

        public void ToggleSleep()
        {
            isSleeping = !isSleeping;
        }
    }
}
