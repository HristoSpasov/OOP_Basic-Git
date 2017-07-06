using System;

namespace _2.Vehicles_Extension.Exceptions
{
    public abstract class VehicleException : Exception
    {
        protected VehicleException(string exceptionMsg) :
            base(exceptionMsg)
        {
        }
    }
}