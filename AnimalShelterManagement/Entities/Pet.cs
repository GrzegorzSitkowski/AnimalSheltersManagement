using AnimalShelterManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Domain.Entities
{
    public class Pet : AuditableEntity
    {
        public string? Name { get; set;}
        public string? Photos { get; set; }
        public int? Age { get; set; }
        public string? Description { get; set; }
        public string? Details { get; set; }
        public Guid? ShelterId { get; set; }
        public Shelter? Shelter { get; set; }
    }
}
