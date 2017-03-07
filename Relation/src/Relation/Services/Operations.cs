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
        private readonly Model _context;//Instance of a model class

        public Operations(Model Context)
        {
            _context = Context;
           // Add(new Student { Name = "Student1" ,Department= "C.S.E"});//addind value manually
        }

        /// <summary>
        /// Get all function.
        ///This function will invoke after calling /api/controller
        /// </summary>
        /// <returns></returns>
        #region
        public IEnumerable<Student> GetAll()

        {
            return _context.students.ToList();
        }
        #endregion

        /// <summary>
        /// Add values to database
        ///sname should be in json format
        /// </summary>
        /// <param name="sname"></param>
        #region
        public void Add(Student sname)
        {
            _context.students.Add(sname);
            _context.SaveChanges();
        }
        #endregion

        /// <summary>
        /// It will find a particulay key that has been find from route
        /// </summary>
        /// <param name="Key"></param>
        /// <returns></returns>
        #region
        public Student Find (long Key)
        {
            return _context.students.FirstOrDefault(t => t.Id == Key);
            }
        #endregion

        /// <summary>
        /// Delete a value from database
        /// </summary>
        /// <param name="key"></param>
        /// it has a lambda function to find a that key from database
        #region
        public void Remove(long key)
        {
            var entity = _context.students.First(t => t.Id == key);
            _context.Remove(entity);
            _context.SaveChanges();
        }
        #endregion



        /// <summary>
        /// Update a particulae cell
        /// </summary>
        /// <param name="sname"></param>
        #region
        public void Update(Student sname)
        {
            _context.students.Update(sname);
            _context.SaveChanges();
            }
        #endregion
    }
}
