using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for, foreach, while loop and do while


            #region For Loop
            //for (int initial = 0; initial < 10; initial++)
            //{
            //    Console.WriteLine(initial);
            //}
            //Console.Read();

            //for (int initial = 0; initial < 50; initial+=5)
            //{
            //    Console.WriteLine(initial);
            //}
            //Console.Read();
            #endregion

            #region Do While
            //Reading the code first before condition
            int counter = 0;
            do
            {
                Console.WriteLine(counter);
                counter++;
            } while (counter < 5);
            Console.Read();
            #endregion

        }
    }
}
