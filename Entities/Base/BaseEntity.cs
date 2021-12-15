using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Base
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; } 
        public bool isActive { get; set; }
    }
}
