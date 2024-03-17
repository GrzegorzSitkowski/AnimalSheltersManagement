using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Application.Shelters.Queries.GetShelters
{
    public class SheltersVm
    {
        ICollection<SheltersDto> Shelters { get; set; }
    }
}
