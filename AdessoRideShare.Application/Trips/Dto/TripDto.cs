using AdessoRideShare.Domain.Enums;
using System;

namespace AdessoRideShare.Application.Trips.Dto
{
    public class TripDto
    {
        public int Id { get; set; }
        public City From { get; set; }
        public City To { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public int Remaining { get; set; }
    }
}
