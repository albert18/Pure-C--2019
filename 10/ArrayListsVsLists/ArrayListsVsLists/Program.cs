using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArrayListsVsLists
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////////////////////////////USING LIST
            List<int> list = new List<int> { 35, 39, 42, 88, 42, 99 };

            Console.WriteLine(list.Contains(99));//return boolean -- looks for an item

            Console.WriteLine(list.Exists(i => i > 65)); //return boolean -- take predicate

            Console.WriteLine(list.Find(i => i > 65)); // find return after 

            List<int> seniorAge = list.FindAll(i => i > 65);// find return list - could return multiple - THE ACTUALLY ITEM
            foreach (int item in seniorAge)
            {
                Console.WriteLine(item);
            }

            int seniorAge1 = list.FindIndex(i => i == 35);// find return list - could return index 
            Console.WriteLine(seniorAge1);
            /////////////////////////////////////////////////////////////////USING LIST
            ///



            // immutable - limited to one type
            int[] scores = new int[] { 99, 96, 87, 76 };

            List<int> list = new List<int> { 1, 2, 3, 4 };
            list.Add(0);
            list.Add(32);
            list.Sort();
            list.RemoveRange(2, 2);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(list.Contains(4));

            int index = list.FindIndex(x => x == 4);
            Console.WriteLine(list[index]);

            list.RemoveAt(index);

            list.ForEach(i => Console.WriteLine(i));

            System.Collections.ArrayList arrayList = new System.Collections.ArrayList();
            arrayList.Add(1);
            arrayList.Add("two");
            arrayList.Add("3");
            arrayList.Add(new Number { n = 4 });


            foreach (Object o in arrayList)
            {
                Console.WriteLine(o);
            }


            Console.ReadLine();
        }
    }

    class Number
    {
        public int n { get; set; }

        public override string ToString()
        {
            return n.ToString();
        }
    }
}
