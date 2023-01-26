using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace P07_CustomException
{
    public class InvalidEmailAddress : Expression
    {
        public InvalidEmailAddress(string message)
        {
        }

        
    }
}
