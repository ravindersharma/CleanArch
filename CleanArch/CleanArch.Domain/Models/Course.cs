using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Models
{
    public class Course
    {
        public int Id { get; set; }
        public required string Name { get; set; }    
        public required string Description { get; set; }
        public required string ImgUrl { get; set; }
        
    }
}
