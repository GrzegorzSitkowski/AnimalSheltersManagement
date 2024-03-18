using AnimalShelterManagement.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Application.Users.Queries.GetUserDetail
{
    public class GetUserDetailQueryHandler : IRequestHandler<GetUserDetailQuery, UserDetailVm>
    {
        private readonly IShelterDbContext _context;

        public GetUserDetailQueryHandler(IShelterDbContext shelterDbContext)
        {
            _context = shelterDbContext;
        }
        public async Task<UserDetailVm> Handle(GetUserDetailQuery request, CancellationToken cancellationToken)
        {
            var user = await _context.Users.Where(p => p.Id == request.UserId).FirstOrDefaultAsync(cancellationToken);

            var userVm = new UserDetailVm()
            {
                UserName = user.UserName.ToString(),
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                City = user.City
            };

            return userVm;
        }
    }
}
