﻿using AnimalShelterManagement.Domain.Common;
using AnimalShelterManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Persistance
{
    public class ShelterDbContext : DbContext
    {
        private string _connectionString = "Server=localhost\\SQLEXPRESS14;Database=ShelterDatabase;Trusted_Connection=True;TrustServerCertificate=True;";
        public ShelterDbContext(DbContextOptions<ShelterDbContext> options) : base(options)
        {

        }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Shelter> Shelters { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().OwnsOne(p => p.UserName);
            modelBuilder.Entity<Shelter>().OwnsOne(p => p.ShelterAddress);

            modelBuilder.SeedData();       
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = string.Empty;
                        entry.Entity.Created = DateTime.Now;
                        entry.Entity.StatusId = 1;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = string.Empty;
                        entry.Entity.Modified = DateTime.Now;
                        break;
                    case EntityState.Deleted:
                        entry.Entity.ModifiedBy = string.Empty;
                        entry.Entity.Modified = DateTime.Now;
                        entry.Entity.Inactivated = DateTime.Now;
                        entry.Entity.InactivatedBy = string.Empty;
                        entry.Entity.StatusId = 0;
                        entry.State = EntityState.Modified;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
