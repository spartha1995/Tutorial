using project_Demo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using project_Demo.Services;

namespace project_Demo.Services
{
    public class CatagoryOperations : ICatagory
    {
        //Instance of a model class
        private readonly ApplicationDbContext _context;
        public CatagoryOperations(ApplicationDbContext Context)
        {
            _context = Context;
        }


        /// <summary>
        /// Adding a Catagory Into Database
        /// </summary>
        /// <param name="catagoryname"></param>
        #region Catagory Name Add
        public void CatagoryAdd(Catagory catagoryname)
        {
            _context.Catagorys.Add(catagoryname);
            _context.SaveChanges();
        }
        #endregion

        /// <summary>
        /// Findind a Respective key from Catagory Table
        /// </summary>
        /// <param name="Key"></param>
        /// <returns></returns>
        #region Finding a Key Catagory Table
        public Catagory CatagoryFind(long Key)
        {
            return _context.Catagorys.FirstOrDefault(t => t.Catagory_Id == Key);
        }
        #endregion


        /// <summary>
        /// Updating a Catagory Name
        /// </summary>
        /// <param name="catagoryname"></param>
        #region Update A Catagory Name

        public void CatagoryUpdate(Catagory catagoryname)
        {
            _context.Catagorys.Update(catagoryname);
            _context.SaveChanges();
        }

        #endregion

    }
}
