using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_lab05_exceptions
{
    internal class MyAnimalException : ApplicationException  // Exception
    {
        public MyAnimalException()
        {
        }

        public MyAnimalException(string? message) : base(message)
        {
         
        }
    }
}
