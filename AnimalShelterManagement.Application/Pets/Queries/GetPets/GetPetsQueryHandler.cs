using AnimalShelterManagement.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Application.Pets.Queries.GetPets
{
    public class GetPetsQueryHandler : IRequestHandler<GetPetsQuery, PetsVm>
    {
        private readonly IShelterDbContext _context;

        public GetPetsQueryHandler(IShelterDbContext shelterDbContext)
        {
            _context = shelterDbContext;
        }
        public async Task<PetsVm> Handle(GetPetsQuery request, CancellationToken cancellationToken)
        {
            var pets = await _context.Pets.AsNoTracking().Where(p => p.StatusId == 1).ToListAsync();

            return new PetsVm();
        }
    }
}
