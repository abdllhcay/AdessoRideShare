using AdessoRideShare.Application.Trips.Commands.CreateTrip;
using AdessoRideShare.Application.Trips.Commands.UpdateTrip;
using AdessoRideShare.Application.Trips.Dto;
using AdessoRideShare.Domain.Entities;
using AutoMapper;

namespace AdessoRideShare.Application.Common.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateTripCommand, Trip>();
            CreateMap<UpdateTripRequest, Trip>();
            CreateMap<Trip, TripDto>();
        }
    }
}
