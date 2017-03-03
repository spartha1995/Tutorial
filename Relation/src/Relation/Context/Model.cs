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


        public Model(DbContextOptions<Model> option) : base(option)
        {

        }
    }
    
}
