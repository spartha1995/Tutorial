using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            #region
            /* Function1();
             Function2();
             Console.ReadLine();*/
            #endregion

            #region
            /* //Threading
             //foreground thread:keep runnning even though main thread exit
             Thread obj1 = new Thread(Function1);
             Thread obj2 = new Thread(Function2);
             obj1.Start();
             obj2.Start();
             Console.ReadLine();*/
            #endregion
            #region
            //A thread will create to run this fucntion 
            //Background Thread
            Thread obj1 = new Thread(Function3);
            obj1.IsBackground = true;
            obj1.Start();
            Console.WriteLine("Main Thread stop Executing");
            Console.ReadLine();
            #endregion
        }

        #region
        /// <summary>
        /// Functions
        /// </summary>
        static void Function1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function1 :{0}", i.ToString());
                Thread.Sleep(2000);
            }
        }
        static void Function2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function2 :{0}", i.ToString());
                Thread.Sleep(2000);
            }

        }
        static void Function3()
        {
            Console.WriteLine("Running");
            Console.ReadLine();//wait here
            Console.WriteLine("function stop executing");
        }
        #endregion
    }
}

