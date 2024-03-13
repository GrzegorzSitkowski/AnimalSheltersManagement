using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Application.Shelters.Queries.GetShelters
{
    public class SheltersDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string ShelterAddress { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
