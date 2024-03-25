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

namespace AnimalShelterManagement.Application.Users.Queries.GetUsers
{
    public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, UsersVm>
    {
        private readonly IShelterDbContext _context;
        private readonly IMapper _mapper;

        public GetUsersQueryHandler(IShelterDbContext shelterDbContext, IMapper mapper)
        {
            _context = shelterDbContext;
            _mapper = mapper;
        }

        public async Task<UsersVm> Handle(GetUsersQuery request, CancellationToken cancellationToken)
        {
            var users = await _context.Users.AsNoTracking().Where(p => p.StatusId == 1).
                ProjectTo<UsersVm>(_mapper.ConfigurationProvider).ToListAsync();

            return new UsersVm();
        }
    }
}
