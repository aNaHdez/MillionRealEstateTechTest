using MediatR;

namespace MillionRealEstateTechTest.Application.Commands.CreateProperty
{
    public record CreatePropertyCommand(string Address, decimal Price) : IRequest<int>;
}
