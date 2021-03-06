﻿using AdessoRideShare.Domain.Enums;
using MediatR;
using System;

namespace AdessoRideShare.Application.Trips.Commands.CreateTrip
{
    public class CreateTripCommand : IRequest
    {
        public int OriginId { get; set; }
        public int DestinationId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
    }
}
