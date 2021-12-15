using Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DomainClasses
{
    public class Student : BaseEntity
    {
        public string Name { get; set; }
        public string FatherName { get; set; }  
        public int ContactNumber { get; set; }
        public int AlternativeContactNumber { get; set; }
        public string? Email { get; set; }  
        public string? Remarks { get; set; }
        public List<Course> Courses { get; set; }
        public List<Batch> Batches { get; set; }
    }
}
