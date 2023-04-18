using System;

namespace Calculator
{
    internal class FormatException : ApplicationException
    {
        public FormatException(string message) : base(message) 
        {
        }
    }
}
