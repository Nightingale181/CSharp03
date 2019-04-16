using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.Exceptions
{
    class BornException : Exception
    {
        public override string Message => "You have not born yet!";
    }
}
