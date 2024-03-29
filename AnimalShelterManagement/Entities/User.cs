﻿using AnimalShelterManagement.Domain.Common;
using AnimalShelterManagement.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Domain.Entities
{
    public class User : AuditableEntity
    {      
        public PersonName? UserName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? City { get; set; }
        public Guid? RoleId { get; set; }
        public Role? Role { get; set; }
    }
}
