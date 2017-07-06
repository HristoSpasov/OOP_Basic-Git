namespace _2.Vehicles_Extension.Exceptions
{
    public class TankOverflowException : VehicleException
    {
        public TankOverflowException() : this("Cannot fit fuel in tank")
        {
        }

        protected TankOverflowException(string exceptionMsg) : base(exceptionMsg)
        {
        }
    }
}