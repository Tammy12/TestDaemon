using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Loader;
using System.Threading;
using System.Threading.Tasks;

namespace TestDaemon
{
    public class Program
    {
        //private bool _running;
        //private Task _myLoop;
        private static bool _isRunning = true;

        public static void Main(string[] args)
        {
            AssemblyLoadContext.Default.Unloading += Default_Unloading;
            while (_isRunning)
            {
                // code here
                Console.WriteLine("I am a service.");
                Thread.Sleep(5000);
            }
        }

        private static void Default_Unloading(AssemblyLoadContext obj)
        {
            _isRunning = false;
            Console.WriteLine("Gracefully stop.");
        }

        //public async Task Start()
        //{
        //    await Task.Delay(1);
        //    _running = true;
        //    _myLoop = Loop();
        //}

        //public async Task Stop()
        //{
        //    _running = false;
        //    await _myLoop;
        //}

        //public async Task Loop()
        //{
        //    while(_running)
        //    {
        //        await Task.Delay(5000);
        //        System.Console.WriteLine("I am a service");
        //    }
        //}
    }
}
