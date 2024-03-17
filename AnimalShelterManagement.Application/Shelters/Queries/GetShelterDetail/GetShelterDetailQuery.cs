using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Application.Shelters.Queries.GetShelterDetail
{
    public  class GetShelterDetailQuery : IRequest<ShelterDetailVm>
    {
        public Guid ShelterId { get; set; }
    }
}
