using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Application.Pets.Queries.GetShelterDetail
{
    public class GetShelterDetailVm
    {
        public string? Name { get; set; }
        public string? Photos { get; set; }
        public int? Age { get; set; }
        public string? Description { get; set; }
        public string? Details { get; set; }
    }
}
