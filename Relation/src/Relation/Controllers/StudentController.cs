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

        [HttpGet]
        public IEnumerable<Student> GetAll()
        {
            return context.GetAll();
        }


        [HttpPost]
        public IActionResult Add([FromBody] Student sname)
        {
            context.Add(sname);
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] Student sname)
        {
            var student = context.Find(id);
            student.Department = sname.Department;
            student.Name = sname.Name;
            context.Update(student);
            return Ok();
        }
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
    }

}
