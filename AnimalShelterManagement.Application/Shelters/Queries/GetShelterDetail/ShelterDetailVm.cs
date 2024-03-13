﻿using AnimalShelterManagement.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Application.Shelters.Queries.GetShelterDetail
{
    public class ShelterDetailVm
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Address? ShelterAddress { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
