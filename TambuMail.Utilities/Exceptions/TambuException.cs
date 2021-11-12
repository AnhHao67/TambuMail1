using System;
using System.Collections.Generic;
using System.Text;

namespace TambuMail.Utilities.Exceptions
{
    public class TambuException : Exception
    {
        public TambuException()
        {
        }

        public TambuException(string message)
            : base(message)
        {
        }

        public TambuException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
