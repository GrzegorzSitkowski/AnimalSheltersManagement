using AnimalShelterManagement.Application.Interfaces;
using AnimalShelterManagement.Application.Shelters.Queries.GetShelters;
using AutoMapper;
using AutoMapper.QueryableExtensions;
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
        private readonly IMapper _mapper;

        public GetPetsQueryHandler(IShelterDbContext shelterDbContext, IMapper mapper)
        {
            _context = shelterDbContext;
            _mapper = mapper;
        }
        public async Task<PetsVm> Handle(GetPetsQuery request, CancellationToken cancellationToken)
        {
            var pets = await _context.Pets.AsNoTracking().Where(p => p.StatusId == 1).
                ProjectTo<SheltersVm>(_mapper.ConfigurationProvider).ToListAsync();

            return new PetsVm();
        }
    }
}
