using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestDaemon.ExceptionHandling
{
    public class LoopCountTooHighException: Exception
    {
        public LoopCountTooHighException(string message) : base(message)
        {

        }
    }
}
