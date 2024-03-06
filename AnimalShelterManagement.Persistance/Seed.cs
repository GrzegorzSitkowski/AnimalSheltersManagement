using AnimalShelterManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Persistance
{
    public static class Seed
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(u =>
            {
                u.HasData(new User()
                {
                    Id = new Guid(),
                    StatusId = 1,
                    Created = DateTime.Now,
                    Email = "mail@example.com",
                    PhoneNumber = "123 456 789",
                    City = "New York"
                });
                u.OwnsOne(u => u.UserName).HasData(new { UserId = 1, FirstName = "Peter", LastName = "Smith" });
            }
            );
        }
    }
}
