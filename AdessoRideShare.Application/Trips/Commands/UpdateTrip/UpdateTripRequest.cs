﻿using AdessoRideShare.Domain.Enums;
using System;

namespace AdessoRideShare.Application.Trips.Commands.UpdateTrip
{
    public class UpdateTripRequest
    {
        public City From { get; set; }
        public City To { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
    }
}