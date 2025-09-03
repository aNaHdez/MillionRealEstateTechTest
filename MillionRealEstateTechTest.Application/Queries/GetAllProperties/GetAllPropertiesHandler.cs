using MediatR;
using MillionRealEstateTechTest.Application.Entities;
using MillionRealEstateTechTest.Application.Interfaces;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MillionRealEstateTechTest.Application.Queries.GetAllProperties
{
    public class GetAllPropertiesHandler : IRequestHandler<GetAllPropertiesQuery, List<Property>>
    {
        private readonly IPropertyRepository _repository;

        public GetAllPropertiesHandler(IPropertyRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Property>> Handle(GetAllPropertiesQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllAsync(cancellationToken);
        }
    }
}
