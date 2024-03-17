using AnimalShelterManagement.Application.Interfaces;
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

        public GetSheltersQueryHandler(IShelterDbContext shelterDbContext)
        {
                _context = shelterDbContext;
        }

        public async Task<SheltersVm> Handle(GetSheltersQuery request, CancellationToken cancellationToken)
        {
            var shelters = await _context.Shelters.AsNoTracking().Where(p => p.StatusId == 1).ToListAsync();

            return new SheltersVm();
        }
    }
}
