using System;

namespace AdessoRideShare.Application.Common.Exceptions
{
    public class CustomException : Exception
    {
        public CustomException(string message)
            : base(message)
        {
        }
    }
}
