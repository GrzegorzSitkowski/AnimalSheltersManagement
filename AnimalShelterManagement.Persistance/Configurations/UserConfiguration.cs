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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.Email).HasMaxLength(100).IsRequired();
            builder.Property(p => p.PhoneNumber).HasMaxLength(100).IsRequired();

            builder.OwnsOne(p => p.UserName).Property(p => p.FirstName).HasColumnName("FirstName").IsRequired();
            builder.OwnsOne(p => p.UserName).Property(p => p.LastName).HasColumnName("LastName").IsRequired();
        }
    }
}
