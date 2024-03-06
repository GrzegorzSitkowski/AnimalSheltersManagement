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
                    Id = Guid.NewGuid(),
                    StatusId = 1,
                    Created = DateTime.Now,
                    Email = "mail@example.com",
                    PhoneNumber = "123 456 789",
                    City = "New York"
                });
                u.OwnsOne(u => u.UserName).HasData(new { UserId = Guid.NewGuid(), FirstName = "Peter", LastName = "Smith" });
            });

            modelBuilder.Entity<Shelter>(s =>
            {
                s.HasData(new Shelter()
                {
                    Id = Guid.NewGuid(),
                    StatusId = 1,
                    Created = DateTime.Now,
                    Name = "New York Shelter",
                    Description = "Shelter for abbandon pets in New York.",
                    Email = "shelterNY@mail.com",
                    PhoneNumber = "123 456 789"
                });
                s.OwnsOne(s => s.ShelterAddress).HasData(new { ShelterId = Guid.NewGuid(), Street = "Street", City = "New York", PostalCode = "61-070" });
            });

            modelBuilder.Entity<Pet>().HasData(
                new Pet() { Id = Guid.NewGuid(), StatusId = 1, Created = DateTime.Now, Name = "Lupin", Age = 3, Description = "Good boy." });
        }
    }
}
