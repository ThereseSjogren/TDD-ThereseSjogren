using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationEngine
{
    public class ExceptionMadeBy:Exception
    {
        public ExceptionMadeBy(string message):base(message)
        {
            
        }
    }
}
