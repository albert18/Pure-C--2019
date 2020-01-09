using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Desktop : Computer, ISleep
    {
        public enum CaseType
        {
            Tower,
            MiniTower
        }

        public bool isSleeping { get; private set; }
        public CaseType caseType { get; set; }



        public override string name
        {
            get
            {
                return base.name + " " + caseType;
            }
        }

        public Desktop(string name, CaseType caseType) : base(name)
        {
            this.caseType = caseType;
        }

        public void ToggleSleep()
        {

            if (!isOn)
            {
                return;
            }
        }
        public override void TogglePower()
        {
            if (isSleeping)
            {
                return;
            }

            base.TogglePower();

        }


    }
}
