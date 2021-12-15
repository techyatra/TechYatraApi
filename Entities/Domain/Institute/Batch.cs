using Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DomainClasses
{
    public class Batch: BaseEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public List<Student> Students { get; set; } 
        public 
    }
}
