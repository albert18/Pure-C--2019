using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Computer
    {
        protected string _name = "unknown";
        public bool IsOn { get; private set; }

        public string name
        {
            get
            {
                return _name;
            }
            private set
            {
                _name = value;
            }
        }

        public Computer(string name)
        {
            this.name = name;
        }

        public void TurnOn()
        {
            IsOn = true;

        }


        public void TurnOff()
        {
            IsOn = false;

        }
    }
}
