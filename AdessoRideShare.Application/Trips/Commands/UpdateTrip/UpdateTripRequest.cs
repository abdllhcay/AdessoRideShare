using System;

namespace AdessoRideShare.Application.Trips.Commands.UpdateTrip
{
    public class UpdateTripRequest
    {
        public int OriginId { get; set; }
        public int DestinationId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
    }
}
