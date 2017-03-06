using Microsoft.AspNetCore.Mvc;
using Relation.Models;
using Relation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Relation.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        public Istudent context { get; set; }
        public StudentController(Istudent stuentdata)

        {
            context = stuentdata;
        }

        /// <summary>
        /// Get Method
        /// It will show values to webpage in json format
        /// </summary>
        /// <returns></returns>
        #region
        [HttpGet]
        public IEnumerable<Student> GetAll()
        {
            return context.GetAll();
        }

        #endregion


        /// <summary>
        /// Post Method
        /// It will add values to database 
        /// </summary>
        /// <param name="sname"></param>
        /// sname is Student type instance
        /// <returns></returns>
        #region
        [HttpPost]
        public IActionResult Add([FromBody] Student sname)
        {
            context.Add(sname);
            return Ok();
        }
        #endregion


        /// <summary>
        /// Put Method
        /// It will update the value of current id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sname"></param>
        /// it will take id from route and sname from body.sname will be in json format 
        /// <returns></returns>
        #region    
        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] Student sname)
        {
            var student = context.Find(id);
            student.Department = sname.Department;
            student.Name = sname.Name;
            context.Update(student);
            return Ok();
        }
        #endregion


        /// <summary>
        /// Delete Method
        /// It Will delete the respective value store in id.
        ///  </summary>
        /// <param name="id"></param>
        /// IT takes id from current route and delete the value
        /// <returns></returns>
        #region
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var todo = context.Find(id);
            if (todo == null)
            {
                return NotFound();
            }
            context.Remove(id);
            return new NoContentResult();
        }
        #endregion


    }

}
