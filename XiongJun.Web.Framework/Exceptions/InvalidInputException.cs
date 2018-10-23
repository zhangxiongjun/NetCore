using System;
using System.Collections.Generic;
using System.Text;

namespace XiongJun.Web.Framework.Exceptions
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException()
        {
        }
        public InvalidInputException(string message)
            : base(message)
        {
        }
    }
}
