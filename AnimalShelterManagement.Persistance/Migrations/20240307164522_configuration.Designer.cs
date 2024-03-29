﻿// <auto-generated />
using System;
using AnimalShelterManagement.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AnimalShelterManagement.Persistance.Migrations
{
    [DbContext(typeof(ShelterDbContext))]
    [Migration("20240307164522_configuration")]
    partial class configuration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AnimalShelterManagement.Domain.Entities.Pet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Age")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Photos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ShelterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ShelterId");

                    b.ToTable("Pets");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d9f5efa3-72c6-4af1-8a65-6885e799410d"),
                            Age = 3,
                            Created = new DateTime(2024, 3, 7, 17, 45, 22, 119, DateTimeKind.Local).AddTicks(3824),
                            Description = "Good boy.",
                            Name = "Lupin",
                            StatusId = 1
                        });
                });

            modelBuilder.Entity("AnimalShelterManagement.Domain.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("AnimalShelterManagement.Domain.Entities.Shelter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Shelters");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bfaf8b00-157c-4cb4-b032-8a46b03f3b6d"),
                            Created = new DateTime(2024, 3, 7, 17, 45, 22, 119, DateTimeKind.Local).AddTicks(3311),
                            Description = "Shelter for abbandon pets in New York.",
                            Email = "shelterNY@mail.com",
                            Name = "New York Shelter",
                            PhoneNumber = "123 456 789",
                            StatusId = 1
                        });
                });

            modelBuilder.Entity("AnimalShelterManagement.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid?>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("14e7b440-b13e-4a1f-97fb-f7769fc4ee27"),
                            City = "New York",
                            Created = new DateTime(2024, 3, 7, 17, 45, 22, 119, DateTimeKind.Local).AddTicks(2045),
                            Email = "mail@example.com",
                            PhoneNumber = "123 456 789",
                            StatusId = 1
                        });
                });

            modelBuilder.Entity("AnimalShelterManagement.Domain.Entities.Pet", b =>
                {
                    b.HasOne("AnimalShelterManagement.Domain.Entities.Shelter", "Shelter")
                        .WithMany("Pets")
                        .HasForeignKey("ShelterId");

                    b.Navigation("Shelter");
                });

            modelBuilder.Entity("AnimalShelterManagement.Domain.Entities.Shelter", b =>
                {
                    b.OwnsOne("AnimalShelterManagement.Domain.ValueObjects.Address", "ShelterAddress", b1 =>
                        {
                            b1.Property<Guid>("ShelterId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("City");

                            b1.Property<string>("PostalCode")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("PostalCode");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Street");

                            b1.HasKey("ShelterId");

                            b1.ToTable("Shelters");

                            b1.WithOwner()
                                .HasForeignKey("ShelterId");

                            b1.HasData(
                                new
                                {
                                    ShelterId = new Guid("e30efb72-d018-4b4e-adab-9ec29cd287d3"),
                                    City = "New York",
                                    PostalCode = "61-070",
                                    Street = "Street"
                                });
                        });

                    b.Navigation("ShelterAddress");
                });

            modelBuilder.Entity("AnimalShelterManagement.Domain.Entities.User", b =>
                {
                    b.HasOne("AnimalShelterManagement.Domain.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");

                    b.OwnsOne("AnimalShelterManagement.Domain.ValueObjects.PersonName", "UserName", b1 =>
                        {
                            b1.Property<Guid>("UserId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("FirstName");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("LastName");

                            b1.HasKey("UserId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");

                            b1.HasData(
                                new
                                {
                                    UserId = new Guid("aa694fc1-3c33-4d4c-851b-d77b1aad6f39"),
                                    FirstName = "Peter",
                                    LastName = "Smith"
                                });
                        });

                    b.Navigation("Role");

                    b.Navigation("UserName");
                });

            modelBuilder.Entity("AnimalShelterManagement.Domain.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("AnimalShelterManagement.Domain.Entities.Shelter", b =>
                {
                    b.Navigation("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}
