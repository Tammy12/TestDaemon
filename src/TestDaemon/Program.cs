using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Loader;
using System.Threading;
using System.Threading.Tasks;
using TestDaemon.ExceptionHandling;

namespace TestDaemon
{
    public class Program
    {
        private static bool _isRunning = true;

        public static void Main(string[] args)
        {
            AssemblyLoadContext.Default.Unloading += Default_Unloading;
            int loopCount = 0;
            try
            {
                while (_isRunning)
                {
                    // code here
                    Console.WriteLine("I am a service.");
                    Thread.Sleep(5000);
                    loopCount++;
                    if(loopCount > 10)
                        throw (new LoopCountTooHighException("Exceeded 10 loops."));
                }
            }
            catch (LoopCountTooHighException ex)
            {
                Console.WriteLine(ex.Message);
                Default_Unloading();
            }
        }

        private static void Default_Unloading(AssemblyLoadContext obj = null)
        {
            _isRunning = false;
            Console.WriteLine("Gracefully stop.");
        }
    }
}
