using AnimalShelterManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Persistance.Configurations
{
    public class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Age).HasMaxLength(10).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(200).IsRequired();
        }
    }
}
