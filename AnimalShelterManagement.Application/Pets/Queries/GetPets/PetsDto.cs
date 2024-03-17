using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Application.Pets.Queries.GetPets
{
    public class PetsDto
    {
        public string? Name { get; set; }
        public string? Photos { get; set; }
        public int? Age { get; set; }
    }
}
