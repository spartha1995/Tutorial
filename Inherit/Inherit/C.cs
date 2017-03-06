using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Claas C
/// Inherit claas B
/// Multiplayer of 5
/// </summary>
namespace Inherit
{
    class C : B
    {
       public void MultiplyBy_5(int a)
        {
            a = a * 5;
        }
    }
}
