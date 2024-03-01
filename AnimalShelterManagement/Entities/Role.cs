using AnimalShelterManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Domain.Entities
{
    public class Role : AuditableEntity
    {
        public ICollection<User>? Users { get; set; }
    }
}
