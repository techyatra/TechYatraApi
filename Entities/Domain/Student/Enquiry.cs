using Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DomainClasses
{
    public class Enquiry : BaseEntity
    {
        public string Name { get; set; }
        public int ContactNumber { get; set; }
        public string FatherName { get; set; }
        public string Address { get; set; }
        public string InterestedCourse { get; set; }
        public DateTime ExpectedJoiningDate { get; set; }
        public EnquiryStatus Status { get; set; }
        public string? Remarks { get; set; }

    }
    public enum EnquiryStatus
    { 
        Negative,
        Positive,
        Sure
    }

}
