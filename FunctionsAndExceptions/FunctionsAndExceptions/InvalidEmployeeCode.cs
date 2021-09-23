using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionsAndExceptions
{
    class InvalidEmployeeCode:Exception
    {
        public InvalidEmployeeCode() : base("Invalid Employee Code")
        {

        }
    }
}
