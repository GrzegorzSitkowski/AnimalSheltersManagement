using AnimalShelterManagement.Application.Common.Mappings;
using AnimalShelterManagement.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Application.Pets.Queries.GetShelterDetail
{
    public class PetDetailVm : IMapFrom<Pet>
    {
        public string? Name { get; set; }
        public string? Photos { get; set; }
        public int? Age { get; set; }
        public string? Description { get; set; }
        public string? Details { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Pet, PetDetailVm>();
        }
    }
}
