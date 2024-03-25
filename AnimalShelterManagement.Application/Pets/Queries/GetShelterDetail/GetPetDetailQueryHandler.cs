using AnimalShelterManagement.Application.Interfaces;
using AutoMapper;
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
        private readonly IMapper _mapper;

        public GetPetDetailQueryHandler(IShelterDbContext shelterDbContext, IMapper mapper)
        {
            _context = shelterDbContext;
            _mapper = mapper;
        }
        public async Task<PetDetailVm> Handle(GetPetDetailQuery request, CancellationToken cancellationToken)
        {
            var pet = await _context.Pets.Where(p => p.Id == request.PetId).FirstOrDefaultAsync(cancellationToken);

            var petVm = _mapper.Map<PetDetailVm>(pet);

            return petVm;
        }
    }
}
