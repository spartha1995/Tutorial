using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Claas B
/// Inherit claas A
/// Multiplayer of 3
/// </summary>
namespace Inherit
{
    class B : A
    {
       public void MultiplyBy_3(int a)
        {
            a = a * 3;
        }
    }
}
