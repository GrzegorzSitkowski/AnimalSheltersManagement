using AnimalShelterManagement.Application.Common.Mappings;
using AnimalShelterManagement.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Application.Pets.Queries.GetPets
{
    public class PetsVm : IMapFrom<Pet>
    {
        public string? Name { get; set; }
        public string? Photos { get; set; }
        public int? Age { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Pet, PetsVm>();
        }
    }
}
