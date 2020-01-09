using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    #region Encapsulation
    //var comp = new Computer("Albert");
    ////comp.name = "Albert";
    ////Console.WriteLine(comp.name);

    //comp.ToggleSwitch();
    //        Console.WriteLine(comp.IsOn);

    //        Console.Read();
    #endregion

    #region Inheritance
    //abstract class have all the business logic without having instanstiated

    #endregion

    class Program
    {
        static void Main(string[] args)
        {

            var comp = new Desktop("Generic Computer");

            Console.WriteLine("Computer Type - " + comp.GetType());

            var isComputer = comp is Computer;

            Console.WriteLine("Is computer - " + isComputer);
            Console.WriteLine("Computer name - " + comp.name);

            comp.TogglePower();
            Console.WriteLine("Computer is on - " + comp.isOn);


            Console.Read();
        }
    }
}
