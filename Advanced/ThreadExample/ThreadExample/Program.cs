using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


/// <summary>
/// Example of thread
/// </summary>
namespace ThreadExample
{
    class Program
    {
        /// <summary>
        /// Creating an instance of Maths class
        /// </summary>
        static Maths objmaths = new Maths();


        static void Main(string[] args)
        {

            Thread t1 = new Thread(objmaths.Divide);//Thread Initialized
            t1.Start();//Thread Start
            objmaths.Divide();
            Console.ReadLine();
        }
        class Maths
        {
            public int num1;
            public int num2;
            /// <summary>
            /// Random is a Represents a pseudo-random number generator,
            /// which is a device that produces a sequence of numbers that meet certain statistical requirements for randomness.
            /// </summary>
            
            Random obj = new Random();
            #region
            public void Divide()
            {
                for (long i = 1; i < 1000000000000; i++)
                {
                    //The lock keyword marks a statement block as a critical section by obtaining the mutual-exclusion lock for a given object, 
                    //executing a statement, and then releasing the lock. 
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
            #endregion
        }
    }
}
