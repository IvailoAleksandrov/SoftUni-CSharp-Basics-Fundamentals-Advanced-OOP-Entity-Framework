using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Smartphone : IBrowsable,ICallable
    {
        public string Browse(string website)
        {
            if (website.Any(x => char.IsDigit(x)))
            {
                throw new ArgumentException("Invalid URL!");
            }
            return $"Browsing: {website}!";
        }

        public string Call(string number)
        {
            if (number.Any(x => !char.IsDigit(x)))
            {
                throw new ArgumentException("Invalid number!");
            }
            
                return $"Calling... {number}";
            
        }
    }
}
