﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Application.Shelters.Queries.GetShelters
{
    public class SheltersVm
    {
        public ICollection<SheltersDto> Shelters { get; set; }
    }
}
