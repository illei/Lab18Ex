using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18Ex.Exceptions
{
    internal class InvalidManfIdException : Exception
    {
        public InvalidManfIdException(string? message) : base(message)
        {
        }
    }
}
