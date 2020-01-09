using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Laptop : Computer, ISleep
    {
        private ISleep sleepCOntroller;

        public Display display { get; private set; }

        public bool isSleeping
        {
            get
            {
                return sleepCOntroller.isSleeping;
            }
        }

        public Laptop(string name, int width, int height) : base(name)
        {
            display = new Display(width, height);
            sleepCOntroller = new SleepController();
        }

        public void ToggleSleep()
        {
            sleepCOntroller.ToggleSleep();
        }
    }
}
