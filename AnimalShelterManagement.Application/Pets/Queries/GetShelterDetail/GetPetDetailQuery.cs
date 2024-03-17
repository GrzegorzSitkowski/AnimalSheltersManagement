using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Application.Pets.Queries.GetShelterDetail
{
    public class GetPetDetailQuery : IRequest<PetDetailVm>
    {
        public Guid PetId { get; set; }
    }
}
