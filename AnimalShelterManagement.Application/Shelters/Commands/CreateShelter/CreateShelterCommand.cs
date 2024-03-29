﻿using AnimalShelterManagement.Application.Common.Mappings;
using AnimalShelterManagement.Domain.Entities;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Application.Shelters.Commands.CreateShelter
{
    public class CreateShelterCommand : IRequest<Guid>
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
