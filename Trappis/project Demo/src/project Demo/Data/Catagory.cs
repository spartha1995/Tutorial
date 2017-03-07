using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project_Demo.Data
{
    public class Catagory
    {
        [Key]
        public int Catagory_Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Catagory_Name { get; set; }
    }
}
