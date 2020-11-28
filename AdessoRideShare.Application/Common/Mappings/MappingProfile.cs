using AdessoRideShare.Application.Trips.Commands.CreateTrip;
using AdessoRideShare.Domain.Entities;
using AutoMapper;

namespace AdessoRideShare.Application.Common.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateTripCommand, Trip>();
        }
    }
}
