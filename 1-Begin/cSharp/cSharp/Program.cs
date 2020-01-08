using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp
{
    #region DataType and Questions

    //DataTypes
    //int, float, double, string, bool,

    //What is a Datatype? - A datatype specifies what type of Value in variable can contain.

    //Which one of the following Datatypes is not considered as "primitive"? - STRING
    //Correct. String is a Class and not a primitive Datatype.It's still a Datatype, thou. It's basically containing multiple Characters.


    //Const are immutable values which are know at compile time and do not change for the life of the program. [Usually Fields]

    //If you want to convert a number into a string. What Kind of conversion is necessary? (Type-Conversion)


    ///////////////////////////////////Sample Code
    //double myDouble = 13.37;
    //int myInt;
    //myInt = (int) myDouble;
    //Console.WriteLine(myInt);

    //Parsing string to int
    //string myString = "15";
    //int myInt = Int32.Parse(myString);
    //Console.WriteLine(myInt);


    //Const are fields
    //const int number = 9;


    #endregion

    #region Methods And Try/Catch -- Unary-Operator

    //try − A try block identifies a block of code for which particular exceptions is activated.It is followed by one or more catch blocks.
    //catch − A program catches an exception with an exception handler at the place in a program where you want to handle the problem.The catch keyword indicates the catching of an exception.
    //finally − The finally block is used to execute a given set of statements, whether an exception is thrown or not thrown.For example, if you open a file, it must be closed whether an exception is raised or not.

    //Unary-Operators do? - Modify the Value of the related Variable
    //What is the Return-Type when using Equality-Operators or Conditional Operators? BOOLEAN


    //Sample Code

    #endregion

    #region Making Decision
    //On a single If-Else-Statement: How many different cases are handled? - One Specific case and one default case
    //What Datatype is necessary for an If-Statement to make decisions? - Booleans do the job
    //An If-Statement within an If-Statement is called. -- Nested


    //Sample Code
    //string number = "128sd";
    //int parseValue;
    //bool success = int.TryParse(number, out parseValue);
    //Console.WriteLine(success);
    #endregion

    #region Loop

    ////int counter = 0;

    ////do
    ////{
    ////    Console.WriteLine(counter);
    ////    counter++;
    ////} while (counter < 5);

    ////while (counter < 10)
    ////{
    ////    Console.WriteLine(counter);
    ////    counter++;
    ////}

    //Console.ReadLine();


    #endregion

    #region Arrays
    //Array - storefixed size sequential collection of elements
    //In an array, every element has the same - data Type




    //Sample Code

    //ArrayList myArrayList = new ArrayList();
    ////ArrayList myArrayList = new ArrayList(100); ways to declare array list
    //myArrayList.Add(25);
    //myArrayList.Add("Hello");


    //List<int> list = new List<int> { 1, 2, 3, 4, 5 };
    #endregion

    #region Inheritance - allows us to define a class in terms of another class, which makes it easier to create and maintain an application.
    //Inheritance inheritance = new Inheritance("Thanks for birthday", true, "Albert");
    //Console.WriteLine(inheritance.ToString());

    //Interface

    #endregion

    #region Polymorphism
    //var cars = new List<Car>
    //        {
    //            new BMW(200, "Blue", "A4"),
    //            new BMW(201, "Black", "A5")
    //        };

    //        foreach (var item in cars)
    //        {
    //            Console.WriteLine(item.HP + " " + item.Color);

    //        }

    //Console.ReadLine();
    #endregion

    #region Advance C#

    #region Access Modifier
    //public class MyClass
    //{
    //    protected int age = 18;

    //    protected void MyMethod()
    //    {


    //    }
    //}

    //class MyClass1 : MyClass
    //{
    //    public void Main()
    //    {
    //        int i = age;
    //        MyMethod();
    //    }
    //} 
    #endregion

    #region Struct
    //it differ from class because it you cannot create contructor  AND implement or more interface
    // Do not support inheritance
    //struct Game
    //{
    //    public string Name { get; set; }
    //    public string developer { get; set; }
    //}
    #endregion

    #region Garbage Collector
    //--> .Net Framework provides automatic memory management




    #endregion

    #region Abstract
    //Shape[] shapes = { new Cube(4) };


    //foreach (Shape shape in shapes)
    //{
    //    shape.GetInfo();
    //    Console.WriteLine("{0} - {1}", shape.Name, shape.Volume());

    //}

    //Console.ReadLine();




    #endregion




    #endregion

    #region Delegate, Anonymous Method

    #region Delegate
    //public delegate double PerformCalculation(double x, double y);

    //public static double Addition(double a, double b)
    //{
    //    Console.WriteLine("a+b is : " + (a + b));
    //    return a + b;
    //}

    //static void Main(string[] args)
    //{

    //    PerformCalculation getSum = Addition;
    //    getSum(5.0, 8.0);


    //} 
    #endregion

    #region Anonymous
    //NOTE:   Method run first before anonymous
    //public delegate string GetTextDelegate(string name);

    //static void Main(string[] args)
    //{
    //    GetTextDelegate getTest = delegate (string name)
    //    {
    //        return "Hello, " + name;
    //    };
    //    Console.WriteLine(getTest("Albert")); ;


    //}


    #endregion

    //Events and Delegate 


    #endregion

    //-----------------------------------------------------------------------------------------------------C# in Tips and Tricks

    #region Encapsulation


    #endregion




    class Program
    {


        static void Main(string[] args)
        {
            var comp = new Computer();
            //comp.name = "Albert";



            //Console.WriteLine("Computer " + comp.GetType());
            //var isComputer = comp is Computer;
            //Console.WriteLine(isComputer);


            Console.Read();

        }

    }
}
