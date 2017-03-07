using project_Demo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_Demo.Services
{
    public interface ICatagory
    {
        void CatagoryAdd(Catagory catagoryName);
        Catagory CatagoryFind(long key);
        void CatagoryUpdate(Catagory catagoryName);
    }
}
