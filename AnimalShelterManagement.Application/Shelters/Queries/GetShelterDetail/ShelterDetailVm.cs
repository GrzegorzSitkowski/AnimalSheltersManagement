using AnimalShelterManagement.Application.Common.Mappings;
using AnimalShelterManagement.Domain.Entities;
using AnimalShelterManagement.Domain.ValueObjects;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Application.Shelters.Queries.GetShelterDetail
{
    public class ShelterDetailVm : IMapFrom<Shelter>
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string ShelterAddress { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Shelter, ShelterDetailVm>();
        }
    }
}
