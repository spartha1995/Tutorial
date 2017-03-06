using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Inherit Example
/// Example of multilevel inheritance
/// </summary>
namespace Inherit
{
    /// <summary>
    /// Class inherit class c
    /// </summary>
    class Program : C
    {
        static void Main(string[] args)
        {
            #region Variables
            int input_user;
            int CountFor_A = 0, CountFor_B = 0, CountFor_c = 0;
            Program obj = new Program();
            Console.WriteLine("Enter the Value");
            input_user = Int32.Parse(Console.ReadLine());
            int temporary = input_user;
            int value_1, value_2, value_3;
            value_1 = value_2 = value_3 = input_user;
            #endregion

            #region if its a Multiplyer by2
            while (value_1 % 2 == 0 && value_1 != 0)
            {
                obj.MultiplyBy_2(value_1);
                value_2 = value_1;
                value_3 = value_1;
                value_1 = value_1 / 2;
                CountFor_A++;
            }
            #endregion

            #region if its a multipley by 3 
            while (value_2 % 3 == 0 && value_2 != 0)
            {
                obj.MultiplyBy_3(value_2);
                value_3 = value_2;
                value_2 = value_2 / 3;
                CountFor_B++;
            }
            #endregion

            #region if its a multiplyer by 5
            while (value_3 % 5 == 0 && value_3 != 0)
            {
                obj.MultiplyBy_5(value_3);
                value_3 = value_3 / 5;
                CountFor_c++;
            }
            #endregion

            #region Console output
            Console.WriteLine("A=>{0}", CountFor_A);
            Console.WriteLine("B=>{0}",CountFor_B);
            Console.WriteLine("C=>{0}",CountFor_c);
            Console.ReadLine();
            #endregion
        }
    }
}
