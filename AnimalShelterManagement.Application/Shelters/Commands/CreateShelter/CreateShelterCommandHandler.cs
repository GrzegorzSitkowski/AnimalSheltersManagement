using AnimalShelterManagement.Application.Interfaces;
using AnimalShelterManagement.Domain.Entities;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Application.Shelters.Commands.CreateShelter
{
    public class CreateShelterCommandHandler : IRequestHandler<CreateShelterCommand, Guid>
    {
        private readonly IShelterDbContext _context;

        public CreateShelterCommandHandler(IShelterDbContext shelterDbContext)
        {
            _context = shelterDbContext; 
        }

        public async Task<Guid> Handle(CreateShelterCommand request, CancellationToken cancellationToken)
        {
            Shelter shelter = new()
            {
                Name = request.Name,
                Description = request.Description,
                ShelterAddress = new Domain.ValueObjects.Address() { City = request.City, PostalCode = request.PostalCode, Street = request.Street },
                Email = request.Email,
                PhoneNumber = request.PhoneNumber
            };

            _context.Shelters.Add(shelter);

            await _context.SaveChangesAsync(cancellationToken);

            return shelter.Id;
        }
    }
}
