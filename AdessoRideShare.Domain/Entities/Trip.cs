using AdessoRideShare.Domain.Common;
using AdessoRideShare.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace AdessoRideShare.Domain.Entities
{
    public class Trip : BaseEntity
    {
        public int OriginId { get; set; }
        public City Origin { get; set; }
        public int DestinationId { get; set; }
        public City Destination { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }

        [ConcurrencyCheck]
        public int Remaining { get; set; }
    }
}
