using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //this class is blue print for datatype
    class Human
    {
        public string FirstName { get; set; }

        //if using contructor this can be private now
        //private string FirstName { get; set; }

        //Multiple Contructor
        public Human(string firstName)
        {
            FirstName = firstName;
        }

        //public Human()
        //{
        //    FirstName = firstName;
        //}

        //method
        public void introduceMySelf()
        {
            Console.WriteLine("Hi I am {0}", FirstName);
        }

    }
}
