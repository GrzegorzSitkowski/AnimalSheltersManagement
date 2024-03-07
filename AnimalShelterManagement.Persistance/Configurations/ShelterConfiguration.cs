using AnimalShelterManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Persistance.Configurations
{
    public class ShelterConfiguration : IEntityTypeConfiguration<Shelter>
    {
        public void Configure(EntityTypeBuilder<Shelter> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
            builder.Property(x => x.PhoneNumber).HasMaxLength(100).IsRequired();
            builder.Property(x => x.ShelterAddress).HasMaxLength(200).IsRequired();

            builder.OwnsOne(p => p.ShelterAddress).Property(p => p.Street).HasColumnName("Street");
            builder.OwnsOne(p => p.ShelterAddress).Property(p => p.City).HasColumnName("City");
            builder.OwnsOne(p => p.ShelterAddress).Property(p => p.PostalCode).HasColumnName("PostalCode");

        }
    }
}
