using AnimalShelterManagement.Application.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Application.Shelters.Queries.GetShelters
{
    public class GetSheltersQueryHandler : IRequestHandler<GetSheltersQuery, SheltersVm>
    {
        private readonly IShelterDbContext _context;
        private readonly IMapper _mapper;

        public GetSheltersQueryHandler(IShelterDbContext shelterDbContext, IMapper mapper)
        {
            _context = shelterDbContext;
            _mapper = mapper;
        }

        public async Task<SheltersVm> Handle(GetSheltersQuery request, CancellationToken cancellationToken)
        {
            var shelters = await _context.Shelters.AsNoTracking().Where(p => p.StatusId == 1).
                ProjectTo<SheltersVm>(_mapper.ConfigurationProvider).ToListAsync();

            return new SheltersVm();
        }
    }
}
