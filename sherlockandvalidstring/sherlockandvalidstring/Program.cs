using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sherlockandvalidstring
{
    class Program
    {
        static void Main(string[] args)
        {
            String String_input;
            Console.WriteLine("Enter String");
            String_input=Console.ReadLine();
            int count = 0, temp = 0, flag = 0;
            for (char ch = 'a'; ch <= 'z'; ch++)
            {
                for (int i = 0; i < String_input.Length; i++)
                {
                    char ch1 = String_input[i];
                    if (ch == ch1)
                        count++;
                }
                if (ch == 'a')
                    temp = count;
                if(ch>='b')
                {
                    if (count != temp && count != 0)
                        flag++;
                }
                if (flag >= 2)
                {
                    Console.WriteLine("NO");
                    ch = 'z';
                }
            }
            if (flag <= 1)
                Console.WriteLine("Yes");
            Console.ReadLine();
        }
    }
}
