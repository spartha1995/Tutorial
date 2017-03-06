using Relation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Relation.Services
{   

    /// <summary>
    /// interface 
    /// </summary>
    public interface Istudent
    {
        void Add(Student sname);
        IEnumerable<Student> GetAll();
        Student Find(long Id);
        void Remove(long Id);
        void Update(Student sname);
    }
}
