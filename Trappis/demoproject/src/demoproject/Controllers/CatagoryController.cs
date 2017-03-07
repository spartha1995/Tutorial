using demoproject.Data;
using demoproject.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoproject.Controllers
{
    [Route("api/[controller]")]
    public class CatagoryController : Controller
    {

        public ICatagory context { get; set; }
        public CatagoryController(ICatagory Catagoryname)
        {
            context = Catagoryname;
        }


        /// <summary>
        /// Post Method 
        /// Url:/api/Catagory
        /// /// </summary>
        /// <param name="catagoryname"></param>
        /// <returns></returns>
        #region post Method 
        [HttpPost]
        public IActionResult AddCatagoryName([FromBody] Catagory catagoryname)
        {
            context.CatagoryAdd(catagoryname);
            return Ok();
        }
        #endregion

        /// <summary>
        /// Put Method
        /// Url:/api/Catagory
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="catagoryname"></param>
        /// <returns></returns>
        #region put Method
        [HttpPut("{id}")]
        public IActionResult UpdateCatagoryName(long Id, [FromBody] Catagory catagoryname)
        {
            var localobjectofcatagory = context.CatagoryFind(Id);
            localobjectofcatagory.Catagory_Name = catagoryname.Catagory_Name;
            context.CatagoryUpdate(localobjectofcatagory);
            return Ok();
        }
        #endregion
    }
}
