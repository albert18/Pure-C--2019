using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Box
    {
        public int length { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public int volume { get; set; }


        //public int length1
        //{
        //    get
        //    {
        //        return length1;
        //    }
        //    set
        //    {
        //        length1 = value
        //    }
        //}

        public void DisplayInfo()
        {
            Console.WriteLine("Lenght is {0} and Height {1} and width {2} so the volume {3}",
                length, height, width, volume = width * height * length);
        }

    }
}
