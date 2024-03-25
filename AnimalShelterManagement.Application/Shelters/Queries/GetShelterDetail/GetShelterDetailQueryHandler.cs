using AnimalShelterManagement.Application.Interfaces;
using AutoMapper;
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
        private readonly IMapper _mapper;

        public GetShelterDetailQueryHandler(IShelterDbContext shelterDbContext, IMapper mapper)
        {
            _context = shelterDbContext;
            _mapper = mapper;
        }

        public async Task<ShelterDetailVm> Handle(GetShelterDetailQuery request, CancellationToken cancellationToken)
        {
            var shelter = await _context.Shelters.Where(p => p.Id == request.ShelterId).FirstOrDefaultAsync(cancellationToken);

            var shelterVm = _mapper.Map<ShelterDetailVm>(shelter);

            return shelterVm;
        }
    }
}
