using AnimalShelterManagement.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Application.Pets.Queries.GetShelterDetail
{
    public class GetPetDetailQueryHandler : IRequestHandler<GetPetDetailQuery, PetDetailVm>
    {
        private readonly IShelterDbContext _context;

        public GetPetDetailQueryHandler(IShelterDbContext shelterDbContext)
        {
            _context = shelterDbContext;
        }
        public async Task<PetDetailVm> Handle(GetPetDetailQuery request, CancellationToken cancellationToken)
        {
            var pet = await _context.Pets.Where(p => p.Id == request.PetId).FirstOrDefaultAsync(cancellationToken);

            var petVm = new PetDetailVm()
            {
                Name = pet.Name,
                Photos = pet.Photos,
                Age = pet.Age,
                Description = pet.Description,
                Details = pet.Details
            };

            return petVm;
        }
    }
}
