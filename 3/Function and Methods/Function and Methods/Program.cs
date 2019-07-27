using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_and_Methods
{
    class Program
    {
        public static void Main(string[] args)
        {
            //WriteSomething();
            //WriteSomethingSpecific("adadasdsa");

            //Console.WriteLine(Add(1, 5)); 

            //TryCatch();



            Console.Read();
        }

        #region Void Methods
        public static void WriteSomething()
        {
            Console.WriteLine("Something Called");

        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }
        #endregion

        #region Methods and Return Value and Parameters
        public static int Add(int par1, int par2)
        {
            return par1 + par2;
        }
        #endregion

        #region Try Catch
        public static void TryCatch()
        {
            Console.WriteLine("Please enter a number!!");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInit = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("For Wrong!!");
            }

            Console.ReadKey();
        } 
        #endregion
    }
}
