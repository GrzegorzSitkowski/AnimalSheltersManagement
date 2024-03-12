using AnimalShelterManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Application.Interfaces
{
    public interface IShelterDbContext
    {
        DbSet<Pet> Pets { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<Shelter> Shelters { get; set; }
        DbSet<User> Users { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
