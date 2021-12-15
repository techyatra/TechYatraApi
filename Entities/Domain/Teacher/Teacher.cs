using Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DomainClasses
{
    internal class Teacher : BaseEntity
    {
        public string Name { get; set; }
        public string FatherName { get; set; }  
        public int ContactNumber { get; set; }
        public int AlternativeContactNumber { get; set; }
        public string Address { get; set; }
        public DateTime JoiningDate { get; set; }
        public DateTime ResignationDate { get; set; }
        public DateTime RelievingDate { get; set; }
        public List<Course> Courses { get; set; }   
    }
}
