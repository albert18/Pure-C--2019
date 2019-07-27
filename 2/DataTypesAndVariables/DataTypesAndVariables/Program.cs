using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Datatypes int, float and double
            int num1 = 13;
            int num2 = 2;
            int sum = num1 + num2;

            double d1 = 3.5;
            double d2 = 1.337;
            double sumD = d1 + d2;

            Console.WriteLine("Sum is " + sum);
            Console.WriteLine("Sum is " + sumD);

            Console.Read();

        }
    }
}
