using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Domain.Entities
{
    public class Role
    {
        public Guid Id { get; set; }
        public User UserId { get; set; }
    }
}
