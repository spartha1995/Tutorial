using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi
{
    class Program
    {
         int m_numdiscs;
        public  void TowerOf_Hanoi()
        {
            numdiscs = 0;
        }
        public  void TowerOf_Hanoi(int newval)
        {
            numdiscs = newval;
        }
        public  int numdiscs
        {
            get
            {
                return m_numdiscs;
            }
            set
            {
                if (value > 0)
                    m_numdiscs = value;
            }
        }
        /// <summary>
        /// Move Tower 
        /// </summary>
        /// <param name="n"></param>
        /// <param Movefrom="from"></param>
        /// <param MoveTO="to"></param>
        /// <param 3rdone="other"></param>
        public void movetower(int n, int from, int to, int other)
        {
            if (n > 0)
            {
                movetower(n - 1, from, other, to);
                Console.WriteLine("Move disk {0} from tower {1} to tower {2}", n, from, to);
                movetower(n - 1, other, to, from);
            }
        }
        static void Main(string[] args)
        {
           Program T = new Program();
            string cnumdiscs;
            Console.Write("Enter the number of discs: ");
            cnumdiscs = Console.ReadLine();
            T.numdiscs = Convert.ToInt32(cnumdiscs);
            T.movetower(T.numdiscs, 1, 3, 2);
            Console.ReadLine();
        }
    }
}
