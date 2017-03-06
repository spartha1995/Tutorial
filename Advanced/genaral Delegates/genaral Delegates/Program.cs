using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genaral_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // func delegate
            //Func is a delegate (pointer) to a method,
            //that takes zero, one or more input parameters, and returns a value (or reference).
            #region Func
            Func<Double, Double> cpointer = r => 3.12 * r * r;
            double Area = cpointer(20);
            Console.WriteLine("Area="+Area);
            #endregion


            //Its an Action Deltgate 
            //Action is a delegate (pointer) to a method, 
            //that takes zero, one or more input parameters, but does not return anything.
            #region Delegate
            Action<string> MyAction = y => Console.WriteLine(y);
            MyAction("Hello");
            #endregion


            //When you want a specialized version of a Func 
            //that takes evaluates a value against a set of criteria and returns a boolean result
            //(true for a match, false otherwise)
            #region predicate
            Predicate<String> CheckGreaterThan5 = x => x.Length > 5;
             Console.WriteLine( CheckGreaterThan5("PromactINfotech"));
            #endregion


            #region Variables
            List<string> string_NAme = new List<string>();
            string_NAme.Add("Promact");
            string_NAme.Add("Promact INfotech");
            string_NAme.Add("Five");
            string str = string_NAme.Find(CheckGreaterThan5);
            Console.WriteLine(str);
            Console.ReadLine();
            #endregion

        }
    }
}
