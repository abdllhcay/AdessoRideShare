﻿using AdessoRideShare.Application.Cities.Dto;
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
            CreateMap<CreateTripCommand, Trip>()
                .ForMember(d => d.Remaining, a => a.MapFrom(s => s.Capacity));
            CreateMap<UpdateTripRequest, Trip>();
            CreateMap<Trip, TripDto>();

            CreateMap<City, CityDto>();
        }
    }
}
