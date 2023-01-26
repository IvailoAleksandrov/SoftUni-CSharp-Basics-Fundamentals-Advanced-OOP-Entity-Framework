using System;
using System.Collections.Generic;
using System.Text;

namespace P07_CustomException
{
    public class InvalidPersonNameException : Exception
    {
        public InvalidPersonNameException()
        {
        }

        public InvalidPersonNameException(string message)
            : base(message)
        {
        }
    }
}
