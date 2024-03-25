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

namespace AnimalShelterManagement.Application.Users.Queries.GetUserDetail
{
    public class GetUserDetailQueryHandler : IRequestHandler<GetUserDetailQuery, UserDetailVm>
    {
        private readonly IShelterDbContext _context;
        private readonly IMapper _mapper;

        public GetUserDetailQueryHandler(IShelterDbContext shelterDbContext, IMapper mapper)
        {
            _context = shelterDbContext;
            _mapper = mapper;
        }
        public async Task<UserDetailVm> Handle(GetUserDetailQuery request, CancellationToken cancellationToken)
        {
            var user = await _context.Users.Where(p => p.Id == request.UserId).FirstOrDefaultAsync(cancellationToken);

            var userVm = _mapper.Map<UserDetailVm>(user);

            return userVm;
        }
    }
}
