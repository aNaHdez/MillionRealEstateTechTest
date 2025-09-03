using MediatR;
using MillionRealEstateTechTest.Application.Entities;
using MillionRealEstateTechTest.Application.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace MillionRealEstateTechTest.Application.Commands.CreateProperty
{
    public class CreatePropertyHandler : IRequestHandler<CreatePropertyCommand, int>
    {
        private readonly IPropertyRepository _repository;

        public CreatePropertyHandler(IPropertyRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(CreatePropertyCommand request, CancellationToken cancellationToken)
        {
            var property = new Property
            {
                Address = request.Address,
                Price = request.Price
            };

            return await _repository.CreateAsync(property, cancellationToken);
        }
    }
}
