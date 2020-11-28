using AdessoRideShare.Domain.Enums;
using System;

namespace AdessoRideShare.Domain.Common
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Status Status { get; set; }
    }
}
