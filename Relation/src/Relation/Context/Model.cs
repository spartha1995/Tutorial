using Microsoft.EntityFrameworkCore;
using Relation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Relation.Context
{
    public class Model : DbContext
    {
        public DbSet<Student> students { get; set; }

        /// <summary>
        /// DbContext must have an instance of DbContextOptions in order to execute. 
        /// This can be configured by overriding OnConfiguring, or supplied externally via a constructor argument.
        /// </summary>
        /// <param name="option"></param>
        /// The base constructor of DbContext also accepts the non-generic version of DbContextOptions. 
        /// Using the non-generic version is not recommended for applications with multiple context types.
        public Model(DbContextOptions<Model> option) : base(option)
        {

        }
    }
    
}
