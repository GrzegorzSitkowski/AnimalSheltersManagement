using AnimalShelterManagement.Application.Interfaces;
using AnimalShelterManagement.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Application.Shelters.Commands.UpdateShelter
{
    public class UpdateShelterCommandHandler : IRequestHandler<UpdateShelterCommand>
    {
        private readonly IShelterDbContext _context;

        public UpdateShelterCommandHandler(IShelterDbContext shelterDbContext)
        {
            _context = shelterDbContext;
        }
        public async Task<Unit> Handle(UpdateShelterCommand request, CancellationToken cancellationToken)
        {
            var shelter = await _context.Shelters.Where(p => p.Id == request.Id).FirstOrDefaultAsync(cancellationToken);

            if (shelter != null)
            {
                shelter.Name = request.Name;
                shelter.Description = request.Description;
                shelter.ShelterAddress.Street = request.Street;
                shelter.ShelterAddress.City = request.City;
                shelter.ShelterAddress.PostalCode = request.PostalCode;
                shelter.Email = request.Email;
                shelter.PhoneNumber = request.PhoneNumber;              
            }

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }

        Task IRequestHandler<UpdateShelterCommand>.Handle(UpdateShelterCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
