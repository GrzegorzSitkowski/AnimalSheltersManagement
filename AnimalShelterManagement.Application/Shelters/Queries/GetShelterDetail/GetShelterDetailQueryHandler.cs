using AnimalShelterManagement.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Application.Shelters.Queries.GetShelterDetail
{
    public class GetShelterDetailQueryHandler : IRequestHandler<GetShelterDetailQuery, ShelterDetailVm>
    {
        private readonly IShelterDbContext _context;

        public GetShelterDetailQueryHandler(IShelterDbContext shelterDbContext)
        {
            _context = shelterDbContext;
        }

        public async Task<ShelterDetailVm> Handle(GetShelterDetailQuery request, CancellationToken cancellationToken)
        {
            var shelter = await _context.Shelters.Where(p => p.Id == request.ShelterId).FirstOrDefaultAsync(cancellationToken);

            var shelterVm = new ShelterDetailVm()
            {
                Name = shelter.Name,
                Description = shelter.Description,
                ShelterAddress = shelter.ShelterAddress.ToString(),
                Email = shelter.Email,
                PhoneNumber = shelter.PhoneNumber
            };

            return shelterVm;
        }
    }
}
