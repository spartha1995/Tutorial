using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadExample
{
    class Program
    {
        static Maths objmaths = new Maths();
        static void Main(string[] args)
        {
            Thread t1 = new Thread(objmaths.Divide);
            t1.Start();
            objmaths.Divide();
            Console.ReadLine();
        }
        class Maths
        {
            public int num1;
            public int num2;

            Random obj = new Random();

            public void Divide()
            {
                for (long i = 1; i < 1000000000000; i++)
                {
                    lock (this)
                    {
                        num1 = obj.Next(1, 2);
                        num2 = obj.Next(1, 2);
                        int result = num1 / num2;
                        num1 = 0;
                        num2 = 0;
                        Console.WriteLine("{0}",result);
                    }
                }
            }
        }
    }
}
