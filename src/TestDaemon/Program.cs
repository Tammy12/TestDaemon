using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TestDaemon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                // code here
                Console.WriteLine("I am a service.");
                Thread.Sleep(5000);
            }
        }
    }
}
