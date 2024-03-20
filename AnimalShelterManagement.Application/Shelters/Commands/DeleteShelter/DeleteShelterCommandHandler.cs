using AnimalShelterManagement.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagement.Application.Shelters.Commands.DeleteShelter
{
    public class DeleteShelterCommandHandler : IRequestHandler<DeleteShelterCommand>
    {
        private readonly IShelterDbContext _context;

        public DeleteShelterCommandHandler(IShelterDbContext shelterDbContext)
        {
            _context = shelterDbContext;
        }

        public async Task<Unit> Handle(DeleteShelterCommand request, CancellationToken cancellationToken)
        {
            var shelter = await _context.Shelters.Where(p => p.Id == request.ShelterId).FirstOrDefaultAsync(cancellationToken);

            _context.Shelters.Remove(shelter);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
