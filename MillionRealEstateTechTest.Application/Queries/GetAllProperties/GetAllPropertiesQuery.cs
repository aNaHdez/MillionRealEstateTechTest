using MediatR;
using MillionRealEstateTechTest.Application.Entities;

namespace MillionRealEstateTechTest.Application.Queries.GetAllProperties
{
    public record GetAllPropertiesQuery() : IRequest<List<Property>>;
}
