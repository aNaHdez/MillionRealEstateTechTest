using MillionRealEstateTechTest.Application.Entities;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MillionRealEstateTechTest.Application.Interfaces
{
    public interface IPropertyRepository
    {
        Task<List<Property>> GetAllAsync(CancellationToken cancellationToken);
        Task<int> CreateAsync(Property property, CancellationToken cancellationToken);
    }
}
