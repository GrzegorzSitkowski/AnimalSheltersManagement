using AnimalShelterManagement.Application.Common.Mappings;
using AnimalShelterManagement.Domain.Entities;
using AnimalShelterManagement.Domain.ValueObjects;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Application.Users.Queries.GetUserDetail
{
    public class UserDetailVm : IMapFrom<User>
    {
        public string UserName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? City { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<User, UserDetailVm>();
        }
    }
}
