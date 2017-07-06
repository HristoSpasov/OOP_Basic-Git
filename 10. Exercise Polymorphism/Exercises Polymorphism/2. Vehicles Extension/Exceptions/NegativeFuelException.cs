namespace _2.Vehicles_Extension.Exceptions
{
    public class NegativeFuelException : VehicleException
    {
        public NegativeFuelException() : this("Fuel must be a positive number")
        {
        }

        protected NegativeFuelException(string exceptionMsg) : base(exceptionMsg)
        {
        }
    }
}