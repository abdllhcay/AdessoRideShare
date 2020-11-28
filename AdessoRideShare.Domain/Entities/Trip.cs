using AdessoRideShare.Domain.Common;
using AdessoRideShare.Domain.Enums;
using System;

namespace AdessoRideShare.Domain.Entities
{
    public class Trip : BaseEntity
    {
        public City From { get; set; }
        public City To { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
    }
}
