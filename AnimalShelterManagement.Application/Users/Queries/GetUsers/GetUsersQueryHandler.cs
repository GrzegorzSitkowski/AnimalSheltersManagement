using AnimalShelterManagement.Application.Interfaces;
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

        public GetUsersQueryHandler(IShelterDbContext shelterDbContext)
        {
            _context = shelterDbContext;
        }

        public async Task<UsersVm> Handle(GetUsersQuery request, CancellationToken cancellationToken)
        {
            var users = await _context.Users.AsNoTracking().Where(p => p.StatusId == 1).ToListAsync();

            return new UsersVm();
        }
    }
}
