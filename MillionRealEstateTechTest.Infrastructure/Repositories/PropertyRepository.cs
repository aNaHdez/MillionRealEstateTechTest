using MillionRealEstateTechTest.Application.Entities;
using MillionRealEstateTechTest.Application.Interfaces;
using MillionRealEstateTechTest.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MillionRealEstateTechTest.Infrastructure.Repositories
{
    public class PropertyRepository : IPropertyRepository
    {
        private readonly AppDbContext _context;

        public PropertyRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Property>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _context.Properties.ToListAsync(cancellationToken);
        }

        public async Task<int> CreateAsync(Property property, CancellationToken cancellationToken)
        {
            _context.Properties.Add(property);
            await _context.SaveChangesAsync(cancellationToken);
            return property.Id; // Asumiendo que Id se genera automáticamente
        }
    }
}
