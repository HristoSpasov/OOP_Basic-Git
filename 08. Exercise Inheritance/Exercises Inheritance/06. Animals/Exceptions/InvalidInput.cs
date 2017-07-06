using System;

namespace _05.Mordor_s_Cruelty_Plan.Exceptions
{
    internal class InvalidInput : Exception
    {
        private InvalidInput(string msg) : base(msg)
        {
        }

        public InvalidInput()
            : this("Invalid input!")
        {
        }
    }
}