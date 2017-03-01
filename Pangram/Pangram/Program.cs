using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter sentence for test : ");
            bool function_return = IsPangram(Console.ReadLine());
            Console.WriteLine(function_return);
            Console.ReadKey();
        }
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
    }
}
