using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    #region Encapsulation

    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            var comp = new Computer("Albert");
            //comp.name = "Albert";
            Console.WriteLine(comp.name);

            Console.Read();
        }
    }
}
