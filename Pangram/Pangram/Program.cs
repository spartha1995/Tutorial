using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Checks a String is Pangram or not
/// </summary>
namespace Pangram
{
    class Program
    {
        #region Main
        static void Main(string[] args)
        {
            Console.Write("Enter sentence for test : ");
            bool function_return = IsPangram(Console.ReadLine());
            Console.WriteLine(function_return);
            Console.ReadKey();
        }
        #endregion

        #region Checks For Pangram
        /// <summary>
        /// input strings Converts into lower case 
        /// check its ascii value 
        /// </summary>
        /// <param name="function_variable"></param>
        /// <returns>bool value True or False</returns>
        static bool IsPangram(string function_variable)
        {
            function_variable = function_variable.ToLower();
            if (function_variable.Length < 26)
                return false;
            bool[] isUsed = new bool[26];
            int total = 0;

            foreach (char charchter in function_variable)
            {
                if (charchter >= 'a' && charchter <= 'z')
                {
                    int index = charchter - 97;
                    if (!isUsed[index])
                    {
                        isUsed[index] = true;
                        total++;
                    }
                }
            }

            return total == 26;
        }
        #endregion
    }
}
