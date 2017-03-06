using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


/// <summary>
/// Simple Thread Example 
/// The following program will wait until main execution stops
/// after that it will execute child thread
/// </summary>
namespace async
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            Method();
            Console.WriteLine("Main Thread");
            Console.ReadLine();
            #endregion
        }
        #region
        public static async void Method()
        {
           await Task.Run(new Action(LongTask));
             Console.WriteLine("New Thread");//wait until the long task finishes
                }
        public static void LongTask()
        {
            Thread.Sleep(200000);
        }
        #endregion
    }
}
