using AdessoRideShare.Domain.Entities;
using System;

namespace AdessoRideShare.Application.Trips.Dto
{
    public class TripDto
    {
        public int Id { get; set; }
        public City Origin { get; set; }
        public City Destination { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public int Remaining { get; set; }
    }
}
