using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Application.Users.Queries.GetUsers
{
    public class GetUsersQuery : IRequest<UsersVm>
    {
    }
}
