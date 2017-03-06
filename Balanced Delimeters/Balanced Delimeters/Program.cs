using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// 
/// </summary>
namespace Balanced_Delimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string string_Input = Console.ReadLine();
            int length = string_Input.Length;
            if (length % 2 == 0)
            {
                while (length > 0 && string_Input.Length > 0)
                {
                    for (int i = 0; i < string_Input.Length; i++)
                    {
                        if (i + 1 < string_Input.Length)
                        {
                            switch (string_Input[i])
                            {
                                case '{':
                                    if (string_Input[i + 1] == '}')
                                        string_Input = string_Input.Remove(i, 2);
                                    break;
                                case '(':
                                    if (string_Input[i + 1] == ')')
                                        string_Input = string_Input.Remove(i, 2);
                                    break;
                                case '[':
                                    if (string_Input[i + 1] == ']')
                                        string_Input = string_Input.Remove(i, 2);
                                    break;
                            }
                        }
                    }
                    length--;
                }
                if (string_Input.Length > 0)
                    Console.WriteLine("False");
                else Console.WriteLine("True");
            }
            else Console.WriteLine("False");
            Console.ReadKey();
        }
    }
}
