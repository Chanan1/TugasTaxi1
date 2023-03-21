using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.DriverName = "chanan artamma";
            taxi.Onduty = true;
            taxi.numPassenger = 22114957;

            taxi.info();
            taxi.jemput();
            taxi.turun();

            Console.ReadKey();
        }
    }
}