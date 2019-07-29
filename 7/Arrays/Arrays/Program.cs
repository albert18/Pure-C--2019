using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
            //first way
            //int[] grades = new int[5];
            //grades[0] = 20;
            //grades[1] = 25;
            //grades[2] = 26;
            //grades[3] = 27;
            //grades[4] = 28;

            //string input = Console.ReadLine();
            //grades[0] = int.Parse(input);

            //Console.WriteLine();
            //Console.Read();

            //second way
            int[] gradeOfMath = { 12, 412, 515, 1123 };

            //thrid way
            int[] gradeOfMathOtherStudent = new int[] { 12, 412, 515, 1123 };


            //Console.WriteLine(gradeOfMath.Length);

            //bool res;
            //int a;
            //string myStr = "12";
            //res = int.TryParse(myStr, out a);
            //Console.WriteLine("String is a numeric representation: " + res); 
            #endregion

            #region Arrays with for each loop
            int[] nums = new int[10];
            for (int i = 0; i < 10; i++)
            {
                nums[i] = i;
            }

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("{0}, {1}",j, nums[j]);
            }
            #endregion
        }
    }
}
