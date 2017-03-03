using Relation.Context;
using Relation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Relation.Services
{
    public class Operations : Istudent
    {
        private readonly Model _context;

        public Operations(Model Context)
        {
            _context = Context;
           // Add(new Student { Name = "Student1" ,Department= "C.S.E"});
        }
        public IEnumerable<Student> GetAll()
        {
            return _context.students.ToList();
        }
        public void Add(Student sname)
        {
            _context.students.Add(sname);
            _context.SaveChanges();
        }
        public Student Find (long Key)
        {
            return _context.students.FirstOrDefault(t => t.Id == Key);
            }
        public void Remove(long key)
        {
            var entity = _context.students.First(t => t.Id == key);
            _context.Remove(entity);
            _context.SaveChanges();
        }
        public void Update(Student sname)
        {
            _context.students.Update(sname);
            _context.SaveChanges();
            }
    }
}
