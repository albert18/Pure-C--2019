using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_Decision
{
    class Program
    {
        static void Main(string[] args)
        {
            #region If Statement

            #endregion

            #region Intro Parse
            ////In case of the string can’t be converted the int.Parse() throws an exceptions where as int.TryParse() return a bool value, false.
            //string numberString = "123";
            //int parsedValue;
            //bool success = int.TryParse(numberString, out parsedValue);
            //int success1 = int.Parse(numberString);

            #endregion

            #region Tenary
            int temp = 66;
            string stateOfmatter = temp >= 100 ? "Yea" : "not";
            string stateOfmatter2 = temp >= 100 ? "Reach the Limit" : temp < 50 ? "Below" : "Average";
            #endregion
        }
    }
}
