using System;
using System.Collections;
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
            //int[] gradeOfMath = { 12, 412, 515, 1123 };

            ////thrid way
            //int[] gradeOfMathOtherStudent = new int[] { 12, 412, 515, 1123 };


            //Console.WriteLine(gradeOfMath.Length);

            //bool res;
            //int a;
            //string myStr = "12";
            //res = int.TryParse(myStr, out a);
            //Console.WriteLine("String is a numeric representation: " + res); 
            #endregion

            #region Arrays with for each loop
            //int[] nums = new int[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    nums[i] = i;
            //}

            //for (int j = 0; j < 10; j++)
            //{
            //    Console.WriteLine("{0}, {1}",j, nums[j]);
            //}
            #endregion

            #region Arrays Parameter
            //int[] studentsGrade = new int[] { 1, 2, 3, 4, 5 };
            //double averageResult = GetAverate(studentsGrade);

            //foreach (int grade in studentsGrade)
            //{
            //    Console.WriteLine("{0}", grade);
            //}

            //Console.WriteLine("Result {0}", averageResult);
            //Console.Read(); 
            #endregion

            #region ArrayList
            //ArrayList myArray = new ArrayList();
            //ArrayList myArray2 = new ArrayList(100);

            //myArray.Add(123);
            //myArray.Add(1234);
            //myArray.Add(1235);
            //myArray.Add("dsadasdsa");

            ////delete element with specific value
            //myArray.Remove(123);

            ////delete element specific position
            //myArray.RemoveAt(1);

            //Console.WriteLine(myArray.Count);

            //----------------------------------------------
            foreach (object obj in myArray)
            {
                Console.WriteLine("This is some test {0}", obj);
            }

            Console.Read();
            #endregion
        }

        #region GetAverate
        //static double GetAverate(int[] gradesArrat)
        //{
        //    int size = gradesArrat.Length;
        //    double average;
        //    int sum = 0;

        //    for (int i = 0; i < size; i++)
        //    {
        //        sum += gradesArrat[i];
        //    }
        //    average = (double)sum / size;
        //    return average;

        //} 
        #endregion
    }
}
