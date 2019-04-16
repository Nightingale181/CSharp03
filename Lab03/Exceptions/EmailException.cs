using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.Exceptions
{
    class EmailException : Exception
    {
        public override string Message => "Email adress is not correct!";
    }
}
