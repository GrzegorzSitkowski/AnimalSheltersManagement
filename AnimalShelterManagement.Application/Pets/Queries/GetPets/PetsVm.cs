using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Application.Pets.Queries.GetPets
{
    public class PetsVm
    {
        public ICollection<PetsDto> Pets { get; set; }
    }
}
