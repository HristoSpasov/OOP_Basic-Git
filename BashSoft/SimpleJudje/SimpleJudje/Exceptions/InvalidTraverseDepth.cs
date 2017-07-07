﻿using System;

namespace SimpleJudje.Exceptions
{
    public class InvalidTraverseDepth : Exception
    {
        private const string InvalidDepth = "Invalid traverse input. Cannot parse {0} to integer.";

        public InvalidTraverseDepth(string invalidInput) :
            base(string.Format(InvalidDepth, invalidInput))
        {
        }
    }
}