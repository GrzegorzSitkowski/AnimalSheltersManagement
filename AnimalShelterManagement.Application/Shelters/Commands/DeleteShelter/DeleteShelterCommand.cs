using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Application.Shelters.Commands.DeleteShelter
{
    public class DeleteShelterCommand : IRequest
    {
        public Guid ShelterId { get; set; }
    }
}
