using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamdba
{
    class Program
    {
        #region
        delegate double CalAreapointer(int r);
        //CalAreapointer cpointer = CalculateArea;

        #endregion
        static void Main(string[] args)
        {
            #region
            //simple function call
            /*double area = cpointer.Invoke(20);
            Console.WriteLine("Area:"+area);
            Console.ReadLine();*/
            #endregion


            #region
            //delegate Lambda
            /*  CalAreapointer cpointer = new CalAreapointer(
                  delegate (int r)
              {
                  return 3.14 * r * r;
              }
              );*/
            #endregion


            #region
            //Lambda
            /* CalAreapointer cpointer = r => 3.12 * r * r;
             double Area = cpointer(20);
             Console.WriteLine("Area : "+Area);
             Console.ReadLine();*/
            #endregion

            #region

            #endregion
        }
        #region
        static double CalculateArea(int r)
        {
            return 3.14 * r * r;
        }
        #endregion
    }
}
