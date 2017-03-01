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
            #region
            // func delegate
            Func<Double, Double> cpointer = r => 3.12 * r * r;
            double Area = cpointer(20);
            Console.WriteLine("Aread="+Area);
            #endregion

            #region
            Action<string> MyAction = y => Console.WriteLine(y);
            MyAction("Hello");
            #endregion

            #region
            Predicate<String> CheckGreaterThan5 = x => x.Length > 5;
             Console.WriteLine( CheckGreaterThan5("PromactINfotech"));
            #endregion

            List<string> string_NAme = new List<string>();
            string_NAme.Add("Promact");
            string_NAme.Add("Promact INfotech");
            string_NAme.Add("Five");
            string str = string_NAme.Find(CheckGreaterThan5);
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
