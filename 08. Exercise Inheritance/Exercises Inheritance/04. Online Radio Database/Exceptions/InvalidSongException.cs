using System;

namespace _04.Online_Radio_Database.Exceptions
{
    internal class InvalidSongException : Exception
    {
        protected InvalidSongException(string exception) : base(exception)
        {
        }

        public InvalidSongException()
            : this("Invalid song")
        {
        }
    }
}