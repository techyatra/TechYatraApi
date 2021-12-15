using Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DomainClasses
{
    public class Course: BaseEntity
    {
        public string Name { get; set; }
        public int DurationInDays { get; set; }

        public decimal Fee { get; set; }
        public string Remarks { get; set; }
    }
}
